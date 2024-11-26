.model small
.stack 100h
.data
    prompt db "?", '$'           ; Prompt to display
    sum_msg db "The sum of ", '$' ; Start of the message
    and_msg db " and ", '$'       ; 'and' part of the message
    is_msg db " is ", '$'         ; 'is' part of the message
    result db 0                   ; To store the result

.code
main proc
    mov ax, @data                 ; Initialize data segment
    mov ds, ax

    ; Display the prompt
    mov ah, 09h
    lea dx, prompt
    int 21h

    ; Read the first number
    mov ah, 01h
    int 21h
    sub al, '0'                   ; Convert ASCII to number
    mov bl, al                    ; Store the first number in BL

    ; Read the second number
    mov ah, 01h
    int 21h
    sub al, '0'                   ; Convert ASCII to number
    add bl, al                    ; Add the two numbers
    mov result, bl                ; Store the result

    ; Display the message
    mov ah, 09h
    lea dx, sum_msg
    int 21h

    ; Display first number
    mov dl, result                ; Load number to display
    add dl, '0'                   ; Convert to ASCII
    mov ah, 02h
