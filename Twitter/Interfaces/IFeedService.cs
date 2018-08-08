using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Model;

namespace Twitter.Interfaces {
    public interface IFeedService {
        List<Publication> GetPublications();
        void AddPublication(Publication publication);
    }
}
