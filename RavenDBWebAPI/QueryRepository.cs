using Raven.Client.Documents;
using Raven.Client.Documents.Operations;
using RavenDBWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDBWebAPI
{
    public class QueryRepository : IQueryRepository
    {
        private readonly IDocumentStore store;
        public QueryRepository(IDocumentStore store)
        {
            this.store = store;
        }
        private static char[] _buffer = new char[6];
        private static string RandomName(Random rand)
        {
            _buffer[0] = (char)rand.Next(65, 91);
            for (int i = 1; i < 6; i++)
            {
                _buffer[i] = (char)rand.Next(97, 123);
            }
            return new string(_buffer);
        }
       

        public void GetFrom3Tables()
        {
            using (var session = store.OpenSession())
            {
                var sp = Stopwatch.StartNew();
                SupportCall supportCall = session.Query<SupportCall, SupportCallByCost>()
                    .Include<SupportCall>(s => s.CustomerId)
                    .Include<SupportCall>(s => s.EmployeeId)
                    .Where(s => s.Cost == 37445).FirstOrDefault();
                Customer customer = session.Load<Customer>(supportCall.CustomerId);
                Employee employee = session.Load<Employee>(supportCall.EmployeeId);
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
            }
        }

        public void GetFroM2Tables()
        {
            using (var session = store.OpenSession())
            {
                var sp = Stopwatch.StartNew();
                SupportCall supportCall = session.Query<SupportCall, SupportCallByCost>()
                    .Include<SupportCall>(s => s.CustomerId)
                    .Where(s => s.Cost == 37445).FirstOrDefault();
                Customer customer = session.Load<Customer>(supportCall.CustomerId);
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
            }
        }

        public Customer GetFromTable()
        {

            Customer customer;
            using (var session = store.OpenSession())
            {
                var sp = Stopwatch.StartNew();
                customer = session.Load<Customer>("1070");
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
            }
            return customer;
        }

        public void Update()
        {
            using (var session = store.OpenSession())
            {
                var sp = Stopwatch.StartNew();
                Customer customer = session.Load<Customer>("1050");
                customer.Name = "Linq";
                session.SaveChanges();
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
            }
        }

        public void Delete()
        {
            using (var session = store.OpenSession())
            {
                var sp = Stopwatch.StartNew();
                Customer customer = session.Load<Customer>("10003");
                session.Delete(customer);
                session.SaveChanges();
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
            }
        }

        public void Patching()
        {
            using (var session = store.OpenSession())
            {
                var sp = Stopwatch.StartNew();
                session.Advanced.Patch<Customer, string>("100", c => c.Name, "Linq");
                session.SaveChanges();
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
            }
        }

        public void DeleteByQuery()
        {
            using (var session = store.OpenSession())
            {
                var sp = Stopwatch.StartNew();
                var operation = store.Operations.Send(new DeleteByQueryOperation<SupportCall, SupportCallByCost>(x => x.Cost < 100));
                session.SaveChanges();
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
            }
        }

        public void Count()
        {
            var sp = Stopwatch.StartNew();
            using (var session = store.OpenSession())
            {
                var rand = new Random();
                sp.Start();
                var numPosts = session.Query<Customer>().Count();
                sp.Stop();
                Console.WriteLine(sp.ElapsedMilliseconds);
                Console.WriteLine(numPosts);
            }
        }
    }
}
