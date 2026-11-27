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
Console.WriteLine("Exemplo de formatação de números com diferentes quantidades de casas decimais");
Console.WriteLine($"{valor:F0}");
Console.WriteLine($"{valor:F1}");
Console.WriteLine($"{valor:F2}");
Console.WriteLine($"{valor:F3}");
Console.WriteLine($"{valor:E2}");

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

//Exemplo de verificação de entrada do usuário


Console.Write("Digite: Parado ou Operando: ");             // Mostra a pergunta sem pular de linha, permitindo digitar ao lado dela.


string status_mostrar = (Console.ReadLine() ?? "").Trim(); // ReadLine lê a entrada; ?? "" substitui null por texto vazio; Trim remove espaços nas extremidades.


if (string.IsNullOrWhiteSpace(status_mostrar))             // Verifica se a entrada está vazia ou contém apenas espaços em branco.
{                                                          // Início do bloco executado quando não há texto.
    Console.WriteLine("Você não digitou nada.");           // Mostra o aviso antes de encerrar.
    return;                                                // Encerra a execução do programa, sem verificar as próximas condições.
}                                                          // Fim do bloco de entrada vazia.

                                                           // Any verifica se algum caractere atende à condição; char.IsDigit identifica dígitos, como 0 a 9.
                                                           // Esta verificação vem primeiro: se houver números e símbolos juntos, o aviso será de números.
if (status_mostrar.Any(char.IsDigit))
{                                                          // Início do bloco executado quando há algum número, inclusive em textos como Parado2.
    Console.WriteLine("Você digitou números. Digite apenas Parado ou Operando."); // Explica o problema.
    return;                                                // Encerra o programa após mostrar o aviso.
}                                                          // Fim do bloco de números.

                                                           // c representa cada caractere; => define a condição; ! significa "não" e && significa "e".
                                                           // Procura caracteres que não sejam letras nem espaços em branco, como @, ! e #.
if (status_mostrar.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
{                                                          // Início do bloco executado quando há símbolos.
    Console.WriteLine("Você digitou símbolos. Digite apenas Parado ou Operando."); // Explica o problema.
    return;                                                // Encerra o programa após mostrar o aviso.
}                                                          // Fim do bloco de símbolos.

                                                           // Declara a variável booleana; seu valor será definido somente se o texto for aceito.
bool emOperacao;

                                                           // Compara com Operando, ignorando diferenças entre letras maiúsculas e minúsculas.
if (status_mostrar.Equals("Operando", StringComparison.OrdinalIgnoreCase))
{                                                          // Início do bloco para o status Operando.
    emOperacao = true;                                     // true indica que está em operação.
}                                                          // Fim do bloco para Operando.
                                                           // Se não era Operando, compara com Parado, também ignorando maiúsculas e minúsculas.
else if (status_mostrar.Equals("Parado", StringComparison.OrdinalIgnoreCase))
{                                                          // Início do bloco para o status Parado.
    emOperacao = false;                                    // false indica que está parado.
}                                                          // Fim do bloco para Parado.
else                                                       // Executado quando o texto não corresponde a nenhum dos dois status permitidos.
{                                                          // Início do bloco de texto inválido.
    Console.WriteLine("Texto inválido. Digite apenas Parado ou Operando."); // Avisa que o texto não é aceito.
    return;                                                // Encerra o programa após o aviso, sem mostrar um status incorreto.
}                                                          // Fim do bloco de texto inválido.

                                                           // Mostra o texto aceito; $ permite inserir o valor da variável entre chaves.
Console.WriteLine($"Status Digitado, {status_mostrar}!");
                                                           // O operador ternário (condição ? valorSeVerdadeiro : valorSeFalso) escolhe qual status mostrar.
Console.WriteLine($"Status: {(emOperacao ? "Operando" : "Parado")}");
