//Para compilar: dotnet build - compila e verifica se tem erros
//Para executar: dotnet run



//Definição de Variável - declaração e atribuição de valor
string nome = "Ana";
int idade = 25;
double altura = 1.68;
bool ativa = true;

/*C# também permite utilizar a palavra-chave var

Nesse caso, o compilador identifica automaticamente o tipo de cada variável.
Entretanto, diferentemente do JavaScript, o tipo inferido continua fixo durante 
a utilização da variável.
*/
var nome2 = "Ana2";
var idade2 = 45;
var altura2 = 1.789;
var ativa2 = true;


//Escrever no console - Terminal
Console.WriteLine("Olá, " + nome2 + "! Idade: " + idade2 + ", Altura: " + altura2 + "m, Ativa: " + ativa2);
Console.WriteLine($"Olá, {nome}! Idade: {idade}, Altura: {altura:F2}m, Ativa: {ativa}");

/*
O símbolo $ antes das aspas indica que estamos utilizando um recurso chamado interpolação 
de strings. Esse recurso permite inserir valores de variáveis e resultados de expressões 
diretamente dentro de um texto, utilizando chaves {}.
Altura: {altura:F2}m - O F indica uma formatação de ponto fixo (fixed-point), enquanto o 
número 2 determina a quantidade de casas decimais.
*/


//Exemplode formatação de números com diferentes quantidades de casas decimais

double valor = 12.34567;
Console.WriteLine("Exemplode formatação de números com diferentes quantidades de casas decimais");
Console.WriteLine($"{valor:F0}");
Console.WriteLine($"{valor:F1}");
Console.WriteLine($"{valor:F2}");
Console.WriteLine($"{valor:F3}");
Console.WriteLine($"{valor:F4}");

/*
Formato	Finalidade	Exemplo de resultado
F2	Duas casas decimais	1500,50
F3	Três casas decimais	1500,500
N2	Número com separador de milhares	1.500,50
C2	Valor monetário	R$ 1.500,50
P2	Percentual (valor original 0,85)	85,00%
D5	Inteiro com preenchimento de zeros	00025
E2	Notação científica	1,50E+003
*/


//Se emOperacao for true, apresenta "Operando". Caso contrário, apresenta "Parado"
bool emOperacao = true;
Console.WriteLine($"Status: {(emOperacao ? "Operando" : "Parado")}");
