1. In master:
   
  - clasele si migrarile
  - indexul si create-ul de la Cars


2. In branch 01:

  - nav bar cu linkurile fiecarei pagini/sectiuni
    
3. In branch 03:
   
  - adaugat clasa Member
  - migrare pt Member cu numele Member1 (migrarea cu numele Member e gresita!)
  - adaugat libraria de clase Razor Identity -> folderul Areas
  - modificat in Program.cs clasa LibraryIdentityContext
  - migrare + update database
  - adaugare in nav bar referinta la view-ul partial _LoginPartial (care a fost generat de Identity)
  - cand se inregistreaza un utilizator nou in aplicatie adresa acestuia de email sa fie salvata concomitent si in tabelul Member -> modificare in fisierul Areas/Identity/Pages/Account/Register.cshtml.cs am sters linkul pt creare si stergere membru din Members\Index.cshtml


4. In branch 02:
  - am facut schimbarile necesare ca in baza de date sa nu se mai duplice datele si sa fie preluate corect la afisarea indexului de la Cars
  - in modelul Car a fost adaugata o proprietate pentru a afisa corespunzator imaginile (URL)

5. In branch 04:
   - am modificat in Register pentru a avea campurile First Name, Last Name, Phone Number la momentul inregistrarii + sa se actualizeze corespunzator in tabelele AspNetUsers si Member
   - am facut modificarile necesare pentru a diferentia la ce pagini are acces utilizatorul conectat ca ADMIN, si cel conectat ca USER, respectiv afisarea butoanelor de EDIT si DELETE doar pentru ADMIN (Cars)
   - creat buton pentru Contact Us, dar fara afisarea datelor adminului
