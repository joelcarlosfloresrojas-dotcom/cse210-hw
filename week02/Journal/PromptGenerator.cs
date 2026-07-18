using System;
using System.Collections.Generic;

public class PromptGenerator{
     public List<string> _prompts = new List<string>(); 
     
     public string GetRandomPrompt(){
           Random choser = new Random();
           int n = choser.Next(0, _prompts.Count);
           return _prompts[n];
     }
}