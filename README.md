# Castiello Coolshop Project

Questo progetto è una console application in C# che legge un file CSV passato dall'utente contenente una lista di ordini di un sito e-commerce e fornisce le seguenti informazioni in output:
- l'ordine con l'importo totale più alto
- l'ordine con la quantità più alta
- l'ordine con la maggior differenza tra totale senza sconto e totale con sconto.

## Struttura del progetto

Il progetto è composto da due file principali:
- **Program.cs**: logica principale del programma.
- **Order.cs**: classe Order che descrive gli ordini.

## Classe Order

La classe Order descrive degli ordini.

### 1. Attributi

- Id
- ArticleName
- Quantity
- UnitPrice
- PercentageDiscount
- Buyer

### 2. Metodi

La classe Order contiene un solo metodo:

- ToString(): restituisce una stringa che descrive l'oggetto

## Main Program

Il file Program.cs contiene la logica principale del programma.

### 1. Funzione getFile()

- Chiede in input all'utente una stringa contenente il percorso del file CSV che desidera analizzare.

### 2. Funzione validateFile()

- Controlla se il file passato come parametro:
    - Ha estensione .csv
    - Esiste
    - Ha almeno una riga
    - Il numero di colonne e il numero di righe è equivalente

### 3. Funzione popolateList()

- Popola una lista passata come parametro
- I dati provengono da un array di stringhe che contiene le linee del file letto

### 4. Funzione highestTotal()

- Utilizzando una LINQ:
    - Ordina in modo decrescente la lista di ordini in base al totale (quantità X prezzo all'unità) meno lo sconto
    - Restituisce solo il primo elemento della query

### 5. Funzione highestQuantity()

- Utilizzando una LINQ:
    - Ordina in modo decrescente la lista di ordini in base alle quantità
    - Restituisce solo il primo elemento della query

### 6. Funzione highestDifference()

- Utilizzando una LINQ:
    - Ordina in modo decrescente la lista di ordini in base alla differenza tra prezzo totale e prezzo scontato
    - Restituisce solo il primo elemento della query

### 7. Main()

Il Main testa le funzioni descritte sopra e restituisce in console:
- L'ordine con il totale più alto
- L'ordine con la quantità più alta
- L'ordine con la differenza tra totale e totale scontato più alta

## File CSV

Il file CSV deve avere un formato simile:

```
Id,ArticleName,Quantity,UnitPrice,PercentageDiscount,Buyer
1,Coke,10,1,0,Mario Rossi
2,Coke,15,2,0,Luca Neri
3,Fanta,5,3,2,Luca Neri
4,Water,20,1,10,Mario Rossi
5,Fanta,1,4,15,Andrea Bianchi
```