using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Interfaces;
using Twitter.Model;

namespace Twitter.Services {
    public class FakeFeedService : IFeedService {
        private List<Publication> Publications { get; set; }

        public void AddPublication(Publication publication) {
            Publications.Add(publication);
        }

        public FakeFeedService() {
            Publications = new List<Publication>();
            Publications.Add(new Publication {
                Content = "First Publication",
                Id = 1,
                PostDate = DateTime.Now,
                PostTheme = new Theme {
                    Id = 1,
                    Name = "Test Theme"
                },
                Sender_Id = 1
            });
            Publications.Add(new Publication {
                Content = "Second Publication",
                Id = 2,
                PostDate = DateTime.Now,
                PostTheme = new Theme {
                    Id = 1,
                    Name = "Test Theme"
                },
                Sender_Id = 1
            });
            Publications.Add(new Publication {
                Content = "Third Publication",
                Id = 3,
                PostDate = DateTime.Now,
                PostTheme = new Theme {
                    Id = 1,
                    Name = "Test Theme"
                },
                Sender_Id = 1
            });
        }

        public List<Publication> GetPublications() {
            return Publications;
        }
    }
}
