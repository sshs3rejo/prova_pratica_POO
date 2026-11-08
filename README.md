# Prova Prática — Programação Orientada a Objetos

Prova prática de POO em **C# (.NET)**: modelagem de veículos com herança, classe abstrata e interface.

## O exercício

Uma transportadora tem veículos de tipos diferentes — caminhões e vans. Todos compartilham dados comuns (identificação, capacidade de carga, combustível) e todos entregam, mas cada um entrega do seu jeito. Além disso, todos precisam passar por manutenção.

O código resolve com três mecanismos de POO:

**1. Classe abstrata `Veiculo`** — o que é comum a todo veículo

```csharp
public abstract class Veiculo
{
    protected string identificacao;
    protected float capacidadeCarga;
    protected string tipoCombustivel;

    public Veiculo(string identificacao, float capacidadeCarga, string tipoCombustivel) { ... }

    public abstract void RegistrarEntrega();
}
```

`protected` em vez de `private` é deliberado: as filhas precisam enxergar esses campos, o resto do mundo não. E `RegistrarEntrega()` é `abstract` — a classe-mãe determina *que* todo veículo entrega, sem determinar *como*.

**2. Interface `IManutencao`** — capacidade separada da hierarquia

```csharp
public interface IManutencao
{
    public string RealizarManutencao();
}
```

Isso importa: manutenção **não é** uma característica de veículo. Um pátio, um elevador ou um gerador também passam por manutenção. Se `RealizarManutencao()` fosse método da classe `Veiculo`, o conceito ficaria preso à hierarquia errada. Interface permite que qualquer classe ganhe essa capacidade sem herdar de `Veiculo`.

**3. Herança nas concretas** — `Caminhao` e `Van` implementam os dois

```csharp
public class Caminhao : Veiculo, IManutencao
{
    public override void RegistrarEntrega() { ... }
    public string RealizarManutencao() { return "Manutenção realizada no caminhão"; }
}
```

`Program.cs` exercita o polimorfismo com uma lista tipada pela abstração:

```csharp
List<Veiculo> lista = new List<Veiculo>();
lista.Add(new Caminhao("ABC-1234", 10, "Diesel"));
lista.Add(new Van("XYZ-5678", 2, "Gasolina"));

foreach (Veiculo v in lista)
    v.RegistrarEntrega();   // chama a versão correta de cada tipo
```

A lista é `List<Veiculo>`, não `List<object>`. É a abstração fazendo seu trabalho: o `foreach` não sabe nem precisa saber se o item é caminhão ou van.

## Rodando

Requisito: .NET SDK 8+

```bash
git clone https://github.com/sshs3rejo/prova_pratica_POO.git
cd prova_pratica_POO
dotnet run
```

## Estrutura

```
├── Veiculo.cs        classe abstrata base
├── IManutencao.cs    interface de manutenção
├── Caminhao.cs       concreta: herda Veiculo, implementa IManutencao
├── Van.cs            concreta: herda Veiculo, implementa IManutencao
└── Program.cs        demonstração do polimorfismo
```

## Licença

MIT
