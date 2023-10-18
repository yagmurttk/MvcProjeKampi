﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {

        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void HeadingAdd(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

        public void HeadingDelete(Heading heading)
        {
            if (heading.HeadingStatus == true)
            {
                heading.HeadingStatus = false;
            }

            else
            {
                heading.HeadingStatus = true;
            }
            _headingDal.Update(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public void CategoryAdd(Heading heading)
        {
            throw new NotImplementedException();
        }

        public List<Heading> GetListByWriter()
        {
            return _headingDal.List(x => x.WriterID == 4);
        }
    }
}
