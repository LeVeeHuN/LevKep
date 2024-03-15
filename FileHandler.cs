using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevKep
{
    internal class FileHandler
    {
        string startupPicture;
        string folderPath;
        string[] allPicture;
        int currentIndex = -1;
        bool isValid = false;

        public bool IsValid { get { return isValid; } }

        // Itt az int x csak lenyomat megkulonboztetesre szolgal
        public FileHandler(string foldername, int x)
        {
            folderPath = foldername;
            string[] files = Directory.GetFiles(folderPath);
            List<string> pictureFiles = new List<string>();
            for (int i = 0; i < files.Length; i++)
            {
                if (IsPicture(files[i]))
                {
                    pictureFiles.Add(files[i]);
                }
            }
            this.allPicture = pictureFiles.ToArray();
            if (this.allPicture.Length > 0)
            {
                currentIndex = 0;
                isValid = true;
                currentIndex = 0;
                startupPicture = this.allPicture[currentIndex];
            }
        }

        public FileHandler(string startupPicture)
        {
            if (!IsPicture(startupPicture))
            {
                return;
            }
            if (startupPicture.Equals(string.Empty))
            {
                return;
            }
            // Ha kep akkor adatok feldolgozasa
            this.startupPicture = startupPicture;
            string[] pathElements = startupPicture.Split(@"\");
            string folderPath = pathElements[0];
            for (int i = 0; i < pathElements.Length - 1; i++)
            {
                folderPath = Path.Combine(folderPath, pathElements[i]);
            }
            this.folderPath = folderPath;
            string[] files = Directory.GetFiles(folderPath);
            List<string> pictureFiles = new List<string>();
            for (int i = 0; i < files.Length; i++)
            {
                if (IsPicture(files[i]))
                {
                    pictureFiles.Add(files[i]);
                }
            }
            this.allPicture = pictureFiles.ToArray();
            if (this.allPicture.Length > 0)
            {
                currentIndex = 0;
                isValid = true;
            }
            for (int i = 0; i < this.allPicture.Length; i++)
            {
                if (this.allPicture[i].Equals(startupPicture))
                {
                    currentIndex = i;
                    break;
                }
            }
        }

        private bool IsPicture(string picture)
        {
            picture = picture.ToLower();
            if (!picture.EndsWith(".jpg") && !picture.EndsWith(".jpeg") && !picture.EndsWith(".png") && !picture.EndsWith(".gif") && !picture.EndsWith(".bmp"))
            {
                return false;
            }
            return true;
        }

        private Image GetImageByIndex(int index)
        {
            return Image.FromFile(allPicture[index]);
        }

        public Image GetCurrentImage()
        {
            if (currentIndex == -1)
            {
                return new Bitmap(100, 100);
            }
            return GetImageByIndex(currentIndex);
        }

        public Image GetNextImage()
        {
            if (currentIndex < allPicture.Length - 1)
            {
                currentIndex++;
            }
            return GetCurrentImage();
        }

        public Image GetPreviousImage()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
            return GetCurrentImage();
        }

        public string GetCurrentImageName()
        {
            if (!isValid)
            {
                return string.Empty;
            }
            string[] currentImagePath = allPicture[currentIndex].Split(@"\");
            return currentImagePath[currentImagePath.Length - 1];
        }
    }
}
