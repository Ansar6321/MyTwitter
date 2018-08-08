using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Interfaces;

namespace Twitter.ViewModel {
    public class MainWindowViewModel : IMainWindowViewModel {
        public IMainWindowView View { get; private set; }
        public IFeedService FeedService { get; private set; }
        public MainWindowViewModel(IMainWindowView view, IFeedService feedService) {
            this.View = view;
            this.FeedService = feedService;
            this.View.BindDataContext(this);
        }
    }
}
