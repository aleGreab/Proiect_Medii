  1. In master:
     
  - clasele si migrarile
  - indexul si create-ul de la Cars
  2. In branch 01:
    
  - nav bar cu linkurile fiecarei pagini/sectiuni
  3. In brach 03:
    
  - adaugat clasa Member
  - migrare pt Member cu numele Member1 (migrarea cu numele Member e gresita!)
  - adaugat libraria de clase Razor Identity -> folderul Areas
  - modificat in Program.cs clasa LibraryIdentityContext
  - migrare + update database
  - adaugare in nav bar referinta la view-ul partial _LoginPartial (care a fost generat de Identity)
  - cand se inregistreaza un utilizator nou in aplicatie adresa acestuia de email sa fie salvata concomitent si in tabelul Member -> modificare in fisierul Areas/Identity/Pages/Account/Register.cshtml.cs
  - am sters linkul pt creare si stergere membru din Members\Index.cshtml
