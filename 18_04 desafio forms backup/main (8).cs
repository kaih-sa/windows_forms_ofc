//Desafio Tecnico-01
using System;
class HelloWorld
{
  static void Main ()
  {

	int idade = 17;
    int numero_segidores;
    int numero_segidores_antes = 672;
    int numero_likes;
    
    char arroba = '@';
    char exclamacao = '!';

            
	float crescimento;
	double crescimento2;
	float visualizacoes;
	float visualizacoes2;
	
	bool pony = false;
	bool humana = false;
	bool os_dois = true;

	string nome_user ="ponyofthesky";
	string nome ="Rainbow Dash";
	
	Console.WriteLine(arroba + "Wonderpony");
	
     Console.WriteLine("Sobre:");
      Console.WriteLine("Nome: " + nome);
	   Console.WriteLine("Idade: " + idade+ " Anos");
	    Console.WriteLine("A Rainbow Dash é? ");
	     Console.WriteLine("Um pony? " + pony);
	      Console.WriteLine("Uma humana? " + humana);
	       Console.WriteLine("Os dois? " + os_dois);
      	 
      	 Console.WriteLine("\nInsira o numero de seguidores");
	      numero_segidores = Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("\nInsira o numero de likes na ultima foto:");
	      numero_likes = Convert.ToInt32(Console.ReadLine());
	
	
	  Console.WriteLine("\nInstagram");
	   Console.WriteLine("Nome: " + nome);
	    Console.WriteLine("Idade: " + idade+ " Anos");
	     Console.WriteLine("Nome de usiario: " + nome_user);
	      Console.WriteLine("Numero de segidores: " + numero_segidores);

      visualizacoes =  numero_segidores * numero_likes;
      visualizacoes2 = visualizacoes - numero_likes;

      
      crescimento =  numero_segidores - numero_segidores_antes;
        crescimento2 =  (crescimento / numero_segidores_antes); 
        
	   Console.WriteLine("Crescimento: " + crescimento2);
       Console.WriteLine("visualizaçoes no perfil: " + visualizacoes2);
       
       Console.WriteLine("É isso" + exclamacao);
  }
}
