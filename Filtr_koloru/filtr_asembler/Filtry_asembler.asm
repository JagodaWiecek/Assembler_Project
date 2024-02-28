;   //////////////////////////////
;   //  autorka: Jagoda Wiêcek  //
;   //  grupa: 1                //
;   //  sekcja: 1               //
;   //  Projekt: filtr koloru   //
;   //  Rok : 2024              //
;   //////////////////////////////

.code
Filtr_color proc

    ;przeniesienie wartoœci argumentów do lokalnych zmiennych
    mov r10, rcx
	mov r11, rdx
	mov r12, r8
    ;przeniesienie wartoœci argumentów do rejestrów 
	mov rax, r9 
	mov rbx, [r10]   ;zmienna gdzie jest kolor czerwony
	mov rcx, [r11]   ;zmienna gdzie jets kolor zielony
	mov rdx, [r12]   ;zmienna gdzie jest kolor niebieski

    ;Sprawdzenie zawartoœci rejestru i skoki do funkcji na podstawie wyniku
    cmp rax, 1      ;sprawdzenie czy liczba jest równa 1
    je case_1       ;jeœli tak, to przeniesie do funkcji filtru koloru czerwonego
    cmp rax, 2      ;sprawdzenie czy liczba jest równa 2
    je case_2       ;jeœli tak, to przeniesie do funkcji filtru koloru niebieskiego
    cmp rax, 3      ;sprawdzenie czy liczba jest równa 3
    je case_3       ;jeœli tak, to przeniesie do funkcji filtru koloru zielonego
    jmp end_p       ;przeniezienie do end_p w razie gdyby nie by³o zadnego dobrego koloru

case_1:
;gdy liczba jest równa 1 
    cmp rbx, 100    ;sprawdzenie czy wartoœæ czerwonego pikselu mieœci siê w przedziale od 100
    jl else_case    ;skok do funkcji robi¹cej œredni¹ kolorów jeœli wartoœæ jest mniejsza ni¿ 100
    cmp rbx, 255    ;sprawdzenie czy wartoœæ czerwonego pikselu mieœci siê w przedziale do 255
    jg else_case    ;skok do funkcji robi¹cej œredni¹ kolorów jeœli wartoœæ wiêksza od 255
    cmp rcx, 0      ;sprawdzenie czy zmienna z kolorem zielonym bêdzie w przedziale od 0 
    jl else_case    ;skok do funkcji robi¹cej œredni¹ kolorów jeœli wartoœæ jest mniejsza ni¿ 0
    cmp rcx, 100     ;sprawdzenie czy zmienna z kolorem zielonym bêdzie w przedziale do 100
    jg else_case    ;skok do funkcji robi¹cej œredni¹ kolorów jeœli wartoœæ jest wieksza ni¿ 100
    cmp rdx, 0      ;sprawdzenie czy zmienna z kolorem niebieskim zawiera siê w przedziale od 0 
    jl else_case    ;skok do funkcji robi¹cej œredni¹ kolorów jeœli wartoœæ jest mniejsza ni¿ 0
    cmp rdx, 100     ;sprawdzenie czy zmienna z kolorem niebieskim zawiera siê w przedziale do 100
    jg else_case    ;skok do funkcji robi¹cej œredni¹ kolorów jeœli zmienna jest wiêksza ni¿ 100

    ;gdy wszystkie wartunki zosta³y spe³nione
    mov rbx, 255    ;kolor czerwony zosta³ ustawiony na jaskrawy 255
    mov rcx, 0      ;kolor zielony zosta³ wyzerowany
    mov rdx, 0      ;kolor niebieski zosta³ wyzerowany
    jmp end_p       ;skok do funkcji koñcz¹cej warunek


else_case:
    ;w momencie niespe³nienia warunków, rozpoczyna siê ta funkcja
    mov rax, rbx    ;przeniesiele wartoœci koloru czerwonego do innego rejestru
    add rax, rcx    ;dodanie wartoœci koloru zielonego do rejestru
    add rax, rdx    ;dodanie wartoœci koloru niebieskiego do rejestru
    mov rbx, 3      ;podzielenie sumy kolorów przez 3 by zyskaæ œredni¹ wartoœæ
    cdq
    idiv rbx        
    mov rcx, rax    ;przeniesienie œredniej wartoœci do zmiennej z zielonym kolorem
    mov rdx, rax    ;przeniesienie œredniej wartoœci do rejestru z niebieskim kolorem
    mov rbx, rax    ;przeniesienie watroœci œredniej do rejestru z czerwonym kolorem
    jmp end_p       ;skok do koñca programu

case_2:
    ;funkcja odpalana kiedy wartoœæ rejestru rax jest równa 2
    cmp rbx, 0      ;sprawdzenie czy wartoœæ koloru czerwonego jest mniejsze ni¿ 0
    jl else_case    ;skok do funkcji robi¹cej œredni¹ kolorów jeœli rbx jest mniejsze ni¿ 0
    cmp rbx, 150     ;sprawdzenie czy wartoœæ koloru czerwonego jest mniejsza ni¿ 150
    jg else_case    ;skok do funkcji gdy zawartoœæ rejestru jest wiêksza od 150
    cmp rcx, 0      ;porównanie czy rejestr koloru zielonego zawiera wartoœæ od 0 wzwy¿
    jl else_case    ;skok do funkcji jeœli rejestr zawiera wartoœæ mniejsz¹ od 0
    cmp rcx, 255    ;porównanie czy wartoœæ koloru zielonego jest mniejsza od 255
    jg else_case    ;skok do funkcji jeœli wartoœæ koloru zielonego jest wiêksza ni¿ 255
    cmp rdx, 150    ;sprawdzenie czy rejestr z wartoœci¹ koloru niebieskiego jest wiêksza ni¿ 150
    jl else_case    ;skok do funkcji jeœli wartoœæ koloru niebieskiego jest mniejsza ni¿ 150
    cmp rdx, 255    ;sprawdzenie czy wartoœæ rejestru koloru niebieskiego jest mniejsza ni¿ 255
    jg else_case    ;skok do funkcji jeœli wartoœæ w rejestrze jest wiêksza ni¿ 255

    ;gdy wszystkie wartunki zosta³y spe³nione
    mov rbx, 0      ;przyrównanie 0 do koloru czerwonego
    mov rcx, 0      ;przyrównanie 0 do koloru zielonego
    mov rdx, 255    ;przrównanie maksymalnej wartoœci pikselów 255 do niebieskiego
    jmp end_p       ;skok do koñca funkcji


case_3:
    ;gdy rejestr rax jest równy 3, czyli filtr koloru zielonego
    cmp rbx, 0       ;sprawdzenie czy kolor czerwony jest wiêkszy ni¿ 0
    jl else_case     ;skok do funkcji jeœli wartoœæ jest mniejsza ni¿ 0
    cmp rbx, 100     ;sprawdzenie czy wartoœæ koloru czerwonego jest mniejsza od 100
    jg else_case     ;skok do funkcji jeœli wartoœæ jest wiêksza ni¿ 100
    cmp rcx, 50     ;porównanie czy kolor zielony jest wiêkszy ni¿ 50
    jl else_case     ;skok do funkcji jeœli wartoœæ zielonego koloru jest mniejsza ni¿ 50
    cmp rcx, 255     ;sprawdzenie czy kolor zielony jest mniejszy ni 255
    jg else_case     ;skok do funkcji jeœli wartoœæ koloru zielonego jest wiêksza ni¿ 255
    cmp rdx, 0       ;porównanie czy wartoœæ koloru niebieskiego jest wiêksza od 0
    jl else_case     ;skok do funkcji jeœli wartoœæ w rejestrze jest mniejsza od 0
    cmp rdx, 100      ;porównanie czy wartoœæ rejestru jest mniejsza od 100
    jg else_case     ;skok jeœli wartoœæ jest wiêksza od 100

   ;gdy wszystkie wartunki zosta³y spe³nione
    mov rbx, 0       ;przyrównanie 0 do koloru czerwonego
    mov rcx, 255     ;przrównanie maksymalnej wartoœci pikselów 255 do zielonego
    mov rdx, 0       ;przyrównanie 0 do koloru niebieskiego
    jmp end_p        ;zakoñczenie programu

end_p:
;przepisanie zawartoœci rejestru
    mov [r10], rbx
	mov [r11], rcx
	mov [r12], rdx

ret
Filtr_color endp
end
