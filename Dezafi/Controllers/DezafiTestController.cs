using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dezafi.Models;

namespace Dezafi.Controllers
{
    public class DezafiTestController : ApiController
    {
        List<WinningNumbersModel> WinnningNumberSet = new List<WinningNumbersModel>() {
           new WinningNumbersModel { CurrentDate = "05/05/2017", WinningNumbers = "3 56 43 8 23 7" },
           new WinningNumbersModel { CurrentDate = "05/06/2017", WinningNumbers = "3 44 22 8 10 4" }
       };

        public IEnumerable<WinningNumbersModel> GetWinningNumbers() {
            return WinnningNumberSet;
        }
    }
}
