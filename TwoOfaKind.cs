
Random GeraNumero = new Random();

int rollUm = 0; // Dado Um
int rollDois = 0;// Dado Dois
int tentativas = 0;// Número de tentativas

Console.WriteLine("Pressione ENTER para rolar o dado");

do { // executa primeiro o código depois verifica a condição WHILE

    Console.ReadKey();

    rollUm = GeraNumero.Next(1, 7); // Pega um número aleatório entre um e seis
    rollDois = GeraNumero.Next(1, 7); // (mesma coisa pro Dado Dois)

    Console.WriteLine("Você tirou um: " + rollUm + "\nVocê tirou um: " + rollDois +"\n=========================");// exibe o resultado
    tentativas++; // acrescenta um ao número de tentativas

} while ((rollUm != rollDois)); // Os dados rolam enquanto um dado não for igual ao outro


Console.WriteLine( "Foram necessárias " + tentativas + " tentativas para tirar dois dados de um tipo");
