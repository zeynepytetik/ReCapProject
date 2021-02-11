using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetCarsByBrandId(int id);
        void add(Brand brand);
        void update(Brand brand);
        void delete(Brand brand);


    }
}
