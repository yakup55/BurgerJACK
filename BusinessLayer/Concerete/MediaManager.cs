using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concerete
{
    public class MediaManager:IMediaService
    {
        IMediaDal _mediaDal;

        public MediaManager(IMediaDal mediaDal)
        {
            _mediaDal = mediaDal;
        }

        public ChecfsSocialMedia GetChecfsSocialMediaByİD(int id)
        {
            return _mediaDal.Get(x=>x.SocialMediaID == id);
        }

        public List<ChecfsSocialMedia> GetList()
        {
            return _mediaDal.List();
        }

        public void MediaAdd(ChecfsSocialMedia media)
        {
            _mediaDal.Insert(media);
        }

        public void MediaDelete(ChecfsSocialMedia media)
        {
            _mediaDal.Delete(media);
        }

        public void MediaUpdate(ChecfsSocialMedia media)
        {
         _mediaDal.Update(media);
        }
    }
}
