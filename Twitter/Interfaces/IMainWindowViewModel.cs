using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Interfaces {
    public interface IMainWindowViewModel {
        IMainWindowView View { get; }
        IFeedService FeedService { get; }
        //добавить еще сервисов
    }
}
