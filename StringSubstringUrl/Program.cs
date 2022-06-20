// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

//string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
//string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
//string padrao = "[0-9]{4}[-][0-9]{4}";
//string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";//com quantificador
//string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";//Trabalha usando código do caractere na tabela ascii
//Grupos de caracteres, como [0123456789];
//Quantificadores: { 4,5},{4} e {?};
//Intervalos de caracteres, como[0 - 9];
//O método estático Regex.IsMatch e Regex.Match; 
Console.WriteLine("Usando IsMatch, Match, Regex. \n");
string padrao = "[0-9]{4,5}-?[0-9]{4}";
string textoDeTeste = "Meu nome é Everton, me ligue em 9784-4546";
Regex.IsMatch(textoDeTeste, padrao);
Match resultado = Regex.Match(textoDeTeste, padrao);

Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
Console.WriteLine(resultado.Value);

//IsMatch retorna se true or false.
//Match retorna o texto desde que esteja dentro do padrão expecificado.
string padrao1 = "Sala [A-G][-]?[0123456789]{3}";
string texto = "Sala G345";
Regex.IsMatch(texto, padrao1);
Match resultado1 = Regex.Match(texto, padrao1);
Console.WriteLine(Regex.IsMatch("Sala G345", padrao1));
Console.WriteLine(Regex.IsMatch("Sala J-001", padrao1));
Console.WriteLine(Regex.IsMatch("Sala a004", padrao1));
Console.WriteLine(Regex.IsMatch("Sala C004", padrao1));
Console.WriteLine(Regex.IsMatch("Minha sala é a sala G34", padrao1));
Console.WriteLine(Regex.IsMatch("Minha sala é a Sala G-34", padrao1));
Console.WriteLine(resultado1.Value + "\n");


Console.WriteLine("Usando IndexOf e Remove. \n");
string urlTeste = "http://Bytebank.com/cambio";
int indiceByteBank = urlTeste.IndexOf("http://Bytebank.com");

Console.WriteLine(indiceByteBank == 0);

//Testeando o método Remove
string testeRemocao = "primeiraParte&parteParRemover";
int indiceEComercial = testeRemocao.IndexOf('&');
Console.WriteLine(testeRemocao.Remove(indiceEComercial));





//moedaOrigem=real&moedaDestino=Dolar

string palavra = "moedaOrigem=real&moedaDestino=Dolar";
string nomeArgumento = "moedaDestino=";

int indice = palavra.IndexOf(nomeArgumento);
Console.WriteLine(indice);

Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);
Console.WriteLine(palavra.Substring(indice));
Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));


 
 //pagina?argumentos
 //012345678
 string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

 int indiceInterrogacao = url.IndexOf('?');

 Console.WriteLine(indiceInterrogacao);

 string argumentos = url.Substring(indiceInterrogacao + 1);
 Console.WriteLine(argumentos);



 Console.ReadLine();
