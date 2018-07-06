using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XR.Repository.Entitys;

namespace XR.Repository.Data
{
    public class TestData : RepositoryBase<TestEntity>
    {
        public bool Add()
        {
            this.Insert(new TestEntity()
            {


                ID = "123123",
                Name = "asdf"
            });
            return true;
        }
    }
}
