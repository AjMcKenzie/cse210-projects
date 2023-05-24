using static System.Console;

public class Scripture{
    
    List<string> word = new List<string>();
    private Reference _reference;


    public Scripture(Reference reference, string text){
        _reference = reference;
    }

    public void Display(){

    }

    // public void HideRandomWord(){
    //     foreach (var word in word){
    //         foreach (char letter in word){
    //             if(Char.IsLetter(letter)){

    //             }
    //             else{

    //             }
    //         }
    //     }
    // }
    
    public void showReference(){
        Write(_reference.GetReference());
    }




}