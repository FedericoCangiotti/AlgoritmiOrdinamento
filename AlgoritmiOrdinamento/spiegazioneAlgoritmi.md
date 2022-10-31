# Spiegazione degli algoritmi di ordinamento

## Selection sort

Questo algoritmo si basa nel suddividere l'array in due parti: una sequenza ordinata di valori (sezione destra) e una disordinata (sezione sinistra).

L'algoritmo termina quando l'array risulterà ordinato ovvero, quando la sequenza disordinata avrà un solo elemento dove quest'ultimo è l'elemento maggiore dell'array.

1. Trovare l’elemento minore all'interno della sequenza disordinata.
2. Scambiare l'elemento minore trovato con l'ultimo elemento della sequenza ordinata (solo se è stato effettivamente trovato un elemento minore).
3. Aggiornare la lunghezza delle due sequenze (incrementare di uno la sequenza ordinata e decrementare di uno la sequenza disordinata).
4. Ripetere il passaggio 1,2 finché non rimane un solo elemento nella sequenza disordinata.
