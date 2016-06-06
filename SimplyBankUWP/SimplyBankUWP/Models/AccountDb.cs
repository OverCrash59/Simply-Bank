using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SimplyBankUWP.Models
{
    public static class AccountDb
    {
        public static Task<Account> GetAccountAsync()
        {
            var json = File.ReadAllText("AccountDb.json");
            var account = JsonConvert.DeserializeObject<Account>(json);
            return Task.FromResult(account);
        }

        public static Task<ObservableCollection<Credit>> GetPeriodicCreditAsync()
        {
            var json = File.ReadAllText("PeriodicCredit.json");
            var periodicCredit = JsonConvert.DeserializeObject<ObservableCollection<Credit>>(json);
            return Task.FromResult(periodicCredit);
        }

        public static Task<ObservableCollection<Flow>> GetPeriodicFlowAsync()
        {
            var json = File.ReadAllText("PeriodicFlow.json");
            var periodicFlow = JsonConvert.DeserializeObject<ObservableCollection<Flow>>(json);
            return Task.FromResult(periodicFlow);
        }
    }
}
