using System;


namespace BaseClass
{
    public abstract class BaseClass : IBase{
        protected abstract void UserInput();
        protected abstract void RandomInput();
        public abstract void Print();
        public abstract void average();
        public void Choice(bool InputByUser){
            if(!InputByUser){
                RandomInput();
            }
            else{
                UserInput();
            }
        }
    }
}
