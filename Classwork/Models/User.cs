using Classwork.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
    public class User
    {
        private static int _id;
        public int Id { get; set; }
        public string Username { get; set; }
        public User(string username)
        {
            _id++;
            Id = _id;
            Username = username;
        }
        public List<Status> statuses = new List<Status>();


        public void ShareStatus(Status status)
        {
            statuses.Add(status);
        }

        public Status GetStatusById(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("Id null ola bilmez");
            }
            return statuses.Find(s => s.Id == id);
        }

        public List<Status> FilterStatusByDate(DateTime date)
        {
            List<Status> filteredStatus = statuses.FindAll(x => x.SharedDate > date);
            if (filteredStatus.Count==0)
            {
                throw new NotFoundException("Bele status tapilmiyoo, yetersiz bakiye ");
            }
            return filteredStatus;
        }
    }
}
