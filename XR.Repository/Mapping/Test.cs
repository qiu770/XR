using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XR.Repository.Entitys;

namespace XR.Repository.Mapping
{
    public class Test : EntityTypeConfiguration<TestEntity>
    {
        public Test()
        {
            this.ToTable("Test");
            this.HasKey(t => t.ID);
        }

    }
}
