using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example
{
    internal class GeneralEntityService
    {
        public FileType FindFileType(int id)
        {
			try
			{
                Thread.Sleep(1000);
            }
			catch (Exception)
			{
				throw;
			}

            FileType fileType = new()
            {
                Id = id,
                Name = "National Defence Ministry"
            };

            return fileType;
        }

        public FileCategory FindFileCategory(int id)
        {
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
                throw;
            }

            FileCategory fileCategory = new()
            {
                Id = id,
                Name = "Top Secret"
            };

            return fileCategory;
        }

        public MyFile CreateFile(int id)
        {
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
                throw;
            }

            MyFile file = new()
            {
                Id = id,
                Name = "Detallar",
                Data = "1asdasd213asdkknkjaskjasdjaksnknknEncryptionaa112sd",
                Category = FindFileCategory(id),
                Type = FindFileType(id)
            };

            return file;
        }
    }
}
