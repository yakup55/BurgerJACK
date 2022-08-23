using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMediaService
    {
        List<ChecfsSocialMedia> GetList();
        void MediaAdd(ChecfsSocialMedia media);
        void MediaUpdate(ChecfsSocialMedia media);
        void MediaDelete(ChecfsSocialMedia media);
        ChecfsSocialMedia GetChecfsSocialMediaByİD(int id);
    }
}
