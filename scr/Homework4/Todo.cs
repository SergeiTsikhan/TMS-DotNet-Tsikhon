using System;

namespace Vidos5_class_oop
{
    public class Todo
    {
        private readonly string Id = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
        private Status _status = Status.inprocesed;
        public readonly DateTime _canditime = DateTime.Now;
        public string Description { get; set; }

        public void SetStatus(Status status)
        {
            _status = status;
        }
        public Todo()
        {
        }
        public string GetID()
        {
            return Id;
        }

        public string Name { get; set; }


        public void Show()
        {
            Console.WriteLine($"time = {_canditime}, Name = {Name}, description = {Description}, status = {_status}, ID = {Id}");
        }

        public Status ChangeStatus(string status)
        {
            return status switch
            {

                "Done" => Status.Done,
                "not_ready" => Status.not_ready,
                "inprocesed" => Status.inprocesed,
                _ => Status.Unknown

            };
        }
      
    }
}
