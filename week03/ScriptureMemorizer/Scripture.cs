public class Scripture
{        
    private List<int> _numerito = new List<int>();
    private List<string> _theword = new List<string>();
    private string _learn;

    public Scripture(List<string> little, List<int> numero)
    {
        _numerito = numero;
        _theword = little;
    }

    public List<string> Getgivemeundercores()
    {
        for(int i = 0; i < _numerito.Count; i++)
        {   
            int go = _numerito[i];
            
        
            int wordLength = _theword[go].Length;
            _theword[go] = new string('_', wordLength);
        }
        return _theword;
    }

    public void DisplayText(List<string> ole, string ref1)
    {
        _learn = string.Join(" ", ole);
        Console.WriteLine(ref1);
        Console.WriteLine(_learn);
    }
}