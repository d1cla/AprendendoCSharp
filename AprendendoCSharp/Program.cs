VerificarIdade();

VerificarPreco();
//Só pode ser: true ou false//
bool estaChovendo = true;
Console.WriteLine(estaChovendo); //(No C#, essa característica de diferenciar maiúsculas de minúsculas chama-se Case Sensitivity.A primeira letra de todas as palavras é maiúscula. Onde usar: Nomes de Classes, Métodos (ações) e Arquivos.Exemplo: Console.WriteLine(), MinhaClasse, CalcularSoma().//
//----------------------------------//
//Usa aspas simples e guarda um único caractere)//
char letra = 'A';
Console.WriteLine(letra);
//----------------------------------//
//Usa aspas duplas e guarda textos//
string nome = "Dicla";
Console.WriteLine(nome);
//----------------------------------//
int idade1 = 18;

if (idade1 >= 18)
{
    Console.WriteLine("É maior de idade");
}
//----------------------------------//
int idade2 = 19;

if (idade2 >= 18) //(if para condição se)//
{ //({} para abrir e fechar blocos)//
    Console.WriteLine("Pode entrar.");
}
else //(Para condição senão))//
{
    Console.WriteLine("Entrada proibida.");
}
//----------------------------------//
int opcao = 2;
//Switch case - o escolhedor, tem muitas opções fixas//
switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu Capuccino");
        //break é obrigatório para parar cada caso.//
        break;

    case 2:
        Console.WriteLine("Você escolheu Água de coco");
        break;

    default:
        Console.WriteLine("Opção inválida");
        break;
}
//----------------------------------//
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    //Isso aumenta o número em 1; não esquecer de aumentar o contador, senão vira loop infinito.//
    contador++;
}
//--------------------------------//
//for é repetição com controle, com a estrutura início; condição; incremento.//
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Número: " + i);
}
//----------------------------------//
string[] nomes = { "Filipe", "Dicla", "Júlia", "Gabriela" }
;

foreach (string nome1 in nomes) //percorre uma lista de itens do começo ao fim, sem precisar de contadores, pega um item por vez da lista.//
{
    Console.WriteLine(nome1);
}

static void VerificarIdade()
{
    //int usado para números inteiros e números negativos, e a estrutura correta é colocar o tipo, o nomeDaVariavel = valor// 
    int idade = 40;
    Console.WriteLine(idade); //coloca ;- ponto e vírgula no final das linhas) (Console.WriteLine() para mostrar algo na tela.//
                              //----------------------------------//
}

static void VerificarPreco()
{
    decimal preco = 15.50m; //sempre colocar o sufixo m para indicar que é um decimal, caso contrário o compilador irá interpretar como double e pode causar erros de precisão//
    Console.WriteLine(preco);
    //----------------------------------//
}
//----------------------------------//
