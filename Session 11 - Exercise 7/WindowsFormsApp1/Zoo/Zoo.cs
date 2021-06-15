using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Zoo {

    public interface IMove {

        string DoMove();
    }

    public interface IEat {

        string DoEat();
    }

    public interface IFly {

        string DoFly();
    }



    public class Cat : IMove, IEat {

        public string DoEat() {
            return "A cat Ate!";
        }

        public string DoMove() {
            return "A cat Moved!";
        }

    }


    public class Dog : IMove, IEat {

        public string DoMove() {
            return "A dog Moved!";
        }

        public string DoEat() {
            return "A dog Ate!";
        }
    }


    public class Bird : IMove, IEat, IFly {

        public string DoMove() {
            return "A bird Moved!";
        }

        public string DoEat() {
            return "A bird Ate!";
        }


        public string DoFly() {
            return "A bird flew!";
        }
    }

    public class AnimalHandler {

        public string Move(IMove movable) {

            return movable.DoMove();
        
        }

        public string Feed(IEat feedble) {

            return feedble.DoEat();

        }


    }
}
