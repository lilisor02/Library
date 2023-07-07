## Tehnologii folosite
C# (LINQ)

## Implementarea solutiei (Console Application):

## 1.	Componente:

•	Clasa Book.cs – creeaza un obiect in care se vor stoca informatiile cu privire la carti. Proprietatile acestui obiectui sunt: nume (string), ISBN (string), pret de inchiriere (float), variabila ce verifica daca este inchiriata deja (bool), numele clientului ce imprumuta cartea (string)
•	Clasa LibraryServices.cs – aici sunt definite ca proprietati: lista de carti a bibliotecii, informatiile necesare pentru stocarea cartilor si imprumutarea/returul lor si doua constante ce reprezinta pretul de inchiriere (am decis sa fie 5 lei) si numarul maxim de zile de inchiriere a unei carti (14 zile). Am implementat cate o metoda pentru fiecare cerinta din problema – pentru adaugarea unei carti in biblioteca, afisarea listei ce contine toate cartile din biblioteca, afisarea numarului de copii pentru o carte, imprumutarea si returul unei carti
•	Program.cs – am creat un meniu folosind switch(), fiecare optiune fiind introdusa de catre utilizator de la tastatura. Fiecare caz din switch reprezinta un apel la metodele declarate in LibraryServices.cs


## 2.	Implementare:

Functionalitatile aplicatiei sunt prezentate intr-un meniu.

![image](https://github.com/lilisor02/Library/assets/72099239/2fe3db33-9812-4ce6-95ad-58ccae1efe7f)

•	Add Book to Library

Se vor introduce de la tastatura numele si ISBN-ul (unic) cartii dorite. Pretul cartii este setat default (5 lei) si are variabila IsBorrowed initial false, deoarece nu a fost inca imprumutata.

![image](https://github.com/lilisor02/Library/assets/72099239/b1187656-1da6-44f6-b74c-ab05856e26b3)

Daca se introduce un ISBN deja existent, se va afisa un mesaj special.

![image](https://github.com/lilisor02/Library/assets/72099239/a3b3339f-e5ef-42c8-b680-1c546d31fe70)

•	Request List of Available Books

Se vor afisa toate cartile introduse in sistem.

![image](https://github.com/lilisor02/Library/assets/72099239/969f562a-9a3b-4d18-bd97-3bd6831c16e4)

•	Check Specific Book Copies

Se va introduce numele cartii dorite si se va afisa numarul de copii al acelei carti.

![image](https://github.com/lilisor02/Library/assets/72099239/80b5008c-65ac-4fae-9c8e-62bcc09d0d4e)

•	Borrow Book

Se vor introduce de la tastatura numele clientului ce imprumuta cartea si ISBN-ul cartii. 
Cazul in care nu exista ISBN-ul inregistrat:

![image](https://github.com/lilisor02/Library/assets/72099239/a1d5d1a1-6c94-4bd6-9670-c5fa482ff782)

Cazul in care exista ISBN-ul inregistrat:

![image](https://github.com/lilisor02/Library/assets/72099239/1296d02e-bafb-459b-8380-68e8cb2a4e3a)

Daca ISBN-ul este inregistrat, pentru cartea cu ISBN-ul respectiv, se va schimba variabila IsBorrowed in true.

![image](https://github.com/lilisor02/Library/assets/72099239/43895b29-ad57-4f12-bbda-99ff4be9fbad)

•	Return Book

Se vor introduce de la tastatura numele clientului, ISBN-ul cartii si numarul de zile de la inchirierea cartii.

Cazul in care ISBN-ul introdus nu exista sau cartea cu acel ISBN nu a fost inchiriata (IsBorrowed = false):

![image](https://github.com/lilisor02/Library/assets/72099239/4b2c90f6-3067-4fb6-9efd-7eacdedaa99e)

Cazul in care ISBN-ul introdus exista si numarul de zile de la inchirierea cartii este mai mic sau egal cu 14:

![image](https://github.com/lilisor02/Library/assets/72099239/31908f3d-d4a4-444b-b27b-e79140c640f6)

Variabila IsBorrowed isi va schimba valoarea in false, deoarece a fost returnata.

![image](https://github.com/lilisor02/Library/assets/72099239/d96805e3-f83f-419e-8bbb-c2b81c401db7)

Cazul in care ISBN-ul introdus exista si numarul de zile de la inchirierea cartii mai mare de 14:

![image](https://github.com/lilisor02/Library/assets/72099239/ad711240-55ba-4a2e-9fac-d9363c9d056e)

Se va calcula numarul de zile depasite de la maximul de 14 zile si se va afisa un mesaj cu taxa pe care clientul o va plati (1/100 * pret de inchiriere / nr zile intarziate). IsBorrowed va deveni false, deoarece cartea a fost returnata.

•	Exit

Se poate parasi aplicatia.

![image](https://github.com/lilisor02/Library/assets/72099239/feac7951-7532-4c89-af98-2240c94d6777)










