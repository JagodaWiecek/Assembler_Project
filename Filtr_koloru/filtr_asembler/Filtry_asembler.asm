;   //////////////////////////////
;   //  autorka: Jagoda Wi�cek  //
;   //  grupa: 1                //
;   //  sekcja: 1               //
;   //  Projekt: filtr koloru   //
;   //  Rok : 2024              //
;   //////////////////////////////

.code
Filtr_color proc

    ;przeniesienie warto�ci argument�w do lokalnych zmiennych
    mov r10, rcx
	mov r11, rdx
	mov r12, r8
    ;przeniesienie warto�ci argument�w do rejestr�w 
	mov rax, r9 
	mov rbx, [r10]   ;zmienna gdzie jest kolor czerwony
	mov rcx, [r11]   ;zmienna gdzie jets kolor zielony
	mov rdx, [r12]   ;zmienna gdzie jest kolor niebieski

    ;Sprawdzenie zawarto�ci rejestru i skoki do funkcji na podstawie wyniku
    cmp rax, 1      ;sprawdzenie czy liczba jest r�wna 1
    je case_1       ;je�li tak, to przeniesie do funkcji filtru koloru czerwonego
    cmp rax, 2      ;sprawdzenie czy liczba jest r�wna 2
    je case_2       ;je�li tak, to przeniesie do funkcji filtru koloru niebieskiego
    cmp rax, 3      ;sprawdzenie czy liczba jest r�wna 3
    je case_3       ;je�li tak, to przeniesie do funkcji filtru koloru zielonego
    jmp end_p       ;przeniezienie do end_p w razie gdyby nie by�o zadnego dobrego koloru

case_1:
;gdy liczba jest r�wna 1 
    cmp rbx, 100    ;sprawdzenie czy warto�� czerwonego pikselu mie�ci si� w przedziale od 100
    jl else_case    ;skok do funkcji robi�cej �redni� kolor�w je�li warto�� jest mniejsza ni� 100
    cmp rbx, 255    ;sprawdzenie czy warto�� czerwonego pikselu mie�ci si� w przedziale do 255
    jg else_case    ;skok do funkcji robi�cej �redni� kolor�w je�li warto�� wi�ksza od 255
    cmp rcx, 0      ;sprawdzenie czy zmienna z kolorem zielonym b�dzie w przedziale od 0 
    jl else_case    ;skok do funkcji robi�cej �redni� kolor�w je�li warto�� jest mniejsza ni� 0
    cmp rcx, 100     ;sprawdzenie czy zmienna z kolorem zielonym b�dzie w przedziale do 100
    jg else_case    ;skok do funkcji robi�cej �redni� kolor�w je�li warto�� jest wieksza ni� 100
    cmp rdx, 0      ;sprawdzenie czy zmienna z kolorem niebieskim zawiera si� w przedziale od 0 
    jl else_case    ;skok do funkcji robi�cej �redni� kolor�w je�li warto�� jest mniejsza ni� 0
    cmp rdx, 100     ;sprawdzenie czy zmienna z kolorem niebieskim zawiera si� w przedziale do 100
    jg else_case    ;skok do funkcji robi�cej �redni� kolor�w je�li zmienna jest wi�ksza ni� 100

    ;gdy wszystkie wartunki zosta�y spe�nione
    mov rbx, 255    ;kolor czerwony zosta� ustawiony na jaskrawy 255
    mov rcx, 0      ;kolor zielony zosta� wyzerowany
    mov rdx, 0      ;kolor niebieski zosta� wyzerowany
    jmp end_p       ;skok do funkcji ko�cz�cej warunek


else_case:
    ;w momencie niespe�nienia warunk�w, rozpoczyna si� ta funkcja
    mov rax, rbx    ;przeniesiele warto�ci koloru czerwonego do innego rejestru
    add rax, rcx    ;dodanie warto�ci koloru zielonego do rejestru
    add rax, rdx    ;dodanie warto�ci koloru niebieskiego do rejestru
    mov rbx, 3      ;podzielenie sumy kolor�w przez 3 by zyska� �redni� warto��
    cdq
    idiv rbx        
    mov rcx, rax    ;przeniesienie �redniej warto�ci do zmiennej z zielonym kolorem
    mov rdx, rax    ;przeniesienie �redniej warto�ci do rejestru z niebieskim kolorem
    mov rbx, rax    ;przeniesienie watro�ci �redniej do rejestru z czerwonym kolorem
    jmp end_p       ;skok do ko�ca programu

case_2:
    ;funkcja odpalana kiedy warto�� rejestru rax jest r�wna 2
    cmp rbx, 0      ;sprawdzenie czy warto�� koloru czerwonego jest mniejsze ni� 0
    jl else_case    ;skok do funkcji robi�cej �redni� kolor�w je�li rbx jest mniejsze ni� 0
    cmp rbx, 150     ;sprawdzenie czy warto�� koloru czerwonego jest mniejsza ni� 150
    jg else_case    ;skok do funkcji gdy zawarto�� rejestru jest wi�ksza od 150
    cmp rcx, 0      ;por�wnanie czy rejestr koloru zielonego zawiera warto�� od 0 wzwy�
    jl else_case    ;skok do funkcji je�li rejestr zawiera warto�� mniejsz� od 0
    cmp rcx, 255    ;por�wnanie czy warto�� koloru zielonego jest mniejsza od 255
    jg else_case    ;skok do funkcji je�li warto�� koloru zielonego jest wi�ksza ni� 255
    cmp rdx, 150    ;sprawdzenie czy rejestr z warto�ci� koloru niebieskiego jest wi�ksza ni� 150
    jl else_case    ;skok do funkcji je�li warto�� koloru niebieskiego jest mniejsza ni� 150
    cmp rdx, 255    ;sprawdzenie czy warto�� rejestru koloru niebieskiego jest mniejsza ni� 255
    jg else_case    ;skok do funkcji je�li warto�� w rejestrze jest wi�ksza ni� 255

    ;gdy wszystkie wartunki zosta�y spe�nione
    mov rbx, 0      ;przyr�wnanie 0 do koloru czerwonego
    mov rcx, 0      ;przyr�wnanie 0 do koloru zielonego
    mov rdx, 255    ;przr�wnanie maksymalnej warto�ci piksel�w 255 do niebieskiego
    jmp end_p       ;skok do ko�ca funkcji


case_3:
    ;gdy rejestr rax jest r�wny 3, czyli filtr koloru zielonego
    cmp rbx, 0       ;sprawdzenie czy kolor czerwony jest wi�kszy ni� 0
    jl else_case     ;skok do funkcji je�li warto�� jest mniejsza ni� 0
    cmp rbx, 100     ;sprawdzenie czy warto�� koloru czerwonego jest mniejsza od 100
    jg else_case     ;skok do funkcji je�li warto�� jest wi�ksza ni� 100
    cmp rcx, 50     ;por�wnanie czy kolor zielony jest wi�kszy ni� 50
    jl else_case     ;skok do funkcji je�li warto�� zielonego koloru jest mniejsza ni� 50
    cmp rcx, 255     ;sprawdzenie czy kolor zielony jest mniejszy ni 255
    jg else_case     ;skok do funkcji je�li warto�� koloru zielonego jest wi�ksza ni� 255
    cmp rdx, 0       ;por�wnanie czy warto�� koloru niebieskiego jest wi�ksza od 0
    jl else_case     ;skok do funkcji je�li warto�� w rejestrze jest mniejsza od 0
    cmp rdx, 100      ;por�wnanie czy warto�� rejestru jest mniejsza od 100
    jg else_case     ;skok je�li warto�� jest wi�ksza od 100

   ;gdy wszystkie wartunki zosta�y spe�nione
    mov rbx, 0       ;przyr�wnanie 0 do koloru czerwonego
    mov rcx, 255     ;przr�wnanie maksymalnej warto�ci piksel�w 255 do zielonego
    mov rdx, 0       ;przyr�wnanie 0 do koloru niebieskiego
    jmp end_p        ;zako�czenie programu

end_p:
;przepisanie zawarto�ci rejestru
    mov [r10], rbx
	mov [r11], rcx
	mov [r12], rdx

ret
Filtr_color endp
end
