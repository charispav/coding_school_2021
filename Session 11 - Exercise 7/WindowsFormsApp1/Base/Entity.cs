using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Base {

    public interface IExecutable {

        void Execute();
    }


    public interface IEntity : IExecutable {

        Guid ID { get; }
    }

    // Class => Base
    public class Base {

    }


    // Class => Inheritance (Base), Implementation (IEntity)
    public class Entity : Base, IEntity {

        public Guid ID { get; private set; }

        public Entity() {
            ID = Guid.NewGuid();
        }

        public void Execute() {
            //throw new NotImplementedException();
        }
    }

    public class EntityHandler {

        public void DoAction(IEntity entity) {
            
            entity.Execute();
        }


    }
}
