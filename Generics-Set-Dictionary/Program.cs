#region Teoria
//Generics

//• Generics permitem que classes, interfaces e métodos possam ser
//parametrizados por tipo. Seus benefícios são: • Reuso
//• Type safety
//• Performance
//• Uso comum: coleções
//List<string> list = new List<string>();
//list.Add("Maria");
//string name = list[0];


//Restrições para generics
//Restrições possíveis
//• https://docs.microsoft.com/en-us/dotnet/csharp/programmingguide/generics/constraints-on-type-parameters
//• where T: struct • where T : class
//• where T : unmanaged
//• where T : new() • where T : < base type name>
//• where T : U

//__________________________________________________________________________________________________________
//GetHashCode e Equals

//• São operações da classe Object utilizadas para comparar se um objeto
//é igual a outro
//• Equals: lento, resposta 100 %
//• GetHashCode: rápido, porém resposta positiva não é 100%
//• Os tipos pré-definidos já possuem implementação para essas
//operações. Classes e structs personalizados precisam sobrepô-las.

//Equals

//Método que compara se o objeto é igual a outro, retornando
//true ou false.

//string a = "Maria";
//string b = "Alex";
//Console.WriteLine(a.Equals(b));

//__________________________________________________________________________________________________________
//GetHashCode
//Método que retorna um número inteiro representando um código gerado
//a partir das informações do objeto

//string a = "Maria";
//string b = "Alex";
//Console.WriteLine(a.GetHashCode());
//Console.WriteLine(b.GetHashCode());

//Regra de ouro do GetHashCode
//• Se o código de dois objetos for diferente, então os dois objetos são
//diferentes
//• Se o código de dois objetos for igual, muito provavelmente os objetos
//são iguais (pode haver colisão)

//__________________________________________________________________________________________________________
//HashSet<T> e SortedSet<T>
//• Representa um conjunto de elementos (similar ao da Álgebra) • Não admite repetições
//• Elementos não possuem posição
//• Acesso, inserção e remoção de elementos são rápidos
//• Oferece operações eficientes de conjunto: interseção, união, diferença. • HashSet • https://msdn.microsoft.com/en-us/library/bb359438(v=vs.110).aspx
//• SortedSet • https://msdn.microsoft.com/en-us/library/dd412070(v=vs.110).aspx

//Diferenças
//• HashSet • Armazenamento em tabela hash
//• Extremamente rápido: inserção, remoção e busca O(1) • A ordem dos elementos não é garantida
//• SortedSet • Armazenamento em árvore
//• Rápido: inserção, remoção e busca O(log(n)) • Os elementos são armazenados ordenadamente conforme implementação
//IComparer<T>

//Alguns métodos importantes
//• Add
//• Clear • Contains
//• UnionWith(other) -operação união: adiciona no conjunto os elementos do outro conjunto, sem repetição
//• IntersectWith(other) -operação interseção: remove do conjunto os elementos não contidos em other • ExceptWith(other)
//    -operação diferença: remove do conjunto os elementos contidos em other • Remove(T) • RemoveWhere(predicate)

//Como as coleções Hash testam igualdade?
//• Se GetHashCode e Equals estiverem implementados: 
//• Primeiro GetHashCode.Se der igual, usa Equals para confirmar.
//• Se GetHashCode e Equals NÃO estiverem implementados: 
//• Tipos referência: compara as referências dos objetos
//• Tipos valor: comparar os valores dos atributos

//__________________________________________________________________________________________________________
//Dictionary e SortedDictionary  ((((((((((((( map )))))))))))))))))

//Dictionary < TKey, TValue >
//• É uma coleção de pares chave / valor • Não admite repetições do objeto chave
//• Os elementos são indexados pelo objeto chave (não possuem posição) • Acesso, inserção e remoção de elementos são rápidos
//• Uso comum: cookies, local storage, qualquer modelo chave-valor • Dictionary
//• https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx
//• SortedDictionary
//• https://msdn.microsoft.com/en-us/library/f7fta44c(v=vs.110).aspx

//Diferenças
//• Dictionary
//• Armazenamento em tabela hash
//• Extremamente rápido: inserção, remoção e busca O(1) • A ordem dos elementos não é garantida
//• SortedDictionary
//• Armazenamento em árvore
//• Rápido: inserção, remoção e busca O(log(n)) • Os elementos são armazenados ordenadamente conforme implementação
//IComparer<T>

//Alguns métodos importantes
//• dictionary[key] -acessa o elemento pela chave informada
//• Add(key, value) -adiciona elemento(exceção em caso de repetição) • Clear() - esvazia a coleção
//• Count - quantidade de elementos
//• ContainsKey(key) -verifica se a dada chave existe
//• ContainsValue(value) -verifica se o dado valor existe
//• Remove(key) -remove um elemento pela chave
//__________________________________________________________________________________________________________



#endregion



using System;

namespace Generics_Set_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    
    }
}
