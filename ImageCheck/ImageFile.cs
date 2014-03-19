using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCheck
{
    public class ImageFile
    {
        public string FullFileName { get; set; }

        public string FileName
        {
            get
            {
                return Path.GetFileName(FullFileName);
            }
            private set
            {
            }
        }
        private bool _deleted; 
        public bool Deleted {
            get
            {
                return _deleted;
            }
            set
            {
                if (value != _deleted)
                {
                    _deleted = value;
                }
            }
        }

        public Image FileImage {
            get
            {
                if (File.Exists(FullFileName))
                {
                    using (Image im = Image.FromFile(FullFileName))
                    {
                        Bitmap bm = new Bitmap(im);
                        return bm;
                    }
                }
                return null;
            }
            private set
            {

            }
        }

        private void Init(string fullFileName) {
            FullFileName = fullFileName;
            Deleted = false;
        }

        public ImageFile() {
            Init(null);
        }

        public ImageFile(string fullFileName)
        {
            Init(fullFileName);
        }

        public override string ToString()
        {
            return FileName;
        }
    }
}
