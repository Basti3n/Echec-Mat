namespace Echec_Mat
{
    public interface IPiece
    {
        int X {get; set;}
        int Y {get; set;}
        
        string Name {get; set;}
        
        string Couleur {get; set;}

        void Move();

        void Print();
    }
}