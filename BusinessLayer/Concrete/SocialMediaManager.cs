using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SocialMediaManager : ISocialMediaService
	{
		ISocialMediaDal _socialmedia;

		public SocialMediaManager(ISocialMediaDal socialmedia)
		{
			_socialmedia = socialmedia;
		}

		public void TAdd(SocialMedia t)
		{
			_socialmedia.Insert(t);
		}

		public void TDelete(SocialMedia t)
		{
			_socialmedia.Delete(t);
		}

		public SocialMedia TGetById(int id)
		{
			return _socialmedia.GetById(id);
		}

		public List<SocialMedia> TGetList()
		{
			return _socialmedia.GetList();
		}

		public List<SocialMedia> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(SocialMedia t)
		{
			_socialmedia.Update(t);
		}
	}
}
