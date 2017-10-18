(************************************************************)
(*                 Higher Order Functions                   *)
(************************************************************)

(*****************     Toolbox   *******************)
(*                 Char and String                 *)
let char_type c =
    if int_of_char c < 123 && int_of_char c > 96 then
      "lower"
    else
      if int_of_char c < 91 && int_of_char c > 64 then
	"upper"
      else
	"other";;

(*let upper_case c =
  if char_type c = "lower" then
    char_of_int((int_of_char c )-32)
  else
    if char_type c = "upper" then
      char_of_int((int_of_char c )+32)
    else
  invalid_arg "not a letter";;*)

let uppercase c =
  if char_type c = "lower" then
    char_of_int((int_of_char c )-32)
  else
    c;;

let lowercase c =
  if char_type c = "upper" then
    char_of_int((int_of_char c )+32)
  else
    c;;

let swap_alpha c =
  if char_type c = "upper" then
    if int_of_char c < 78 then
      char_of_int(78+(77-(int_of_char c)))
    else
      char_of_int(78-((int_of_char c)-77))
  else
    if char_type c = "lower" then
      if int_of_char c < 110 then
	char_of_int(110+(109-(int_of_char c)))
      else
	char_of_int(110-((int_of_char c)-109))
    else
      invalid_arg "not a char";;
char_of_int 97;;

let rotn n c =
  if char_type c = "upper" then
    if (int_of_char c) + n > 90 then
      char_of_int((int_of_char c)+n-26)
    else
      if (int_of_char c) + n < 65 then
	char_of_int((int_of_char c) + n +26)
      else
	char_of_int((int_of_char c) + n)
  else
    if char_type c = "lower" then
      if (int_of_char c) + n > 122 then
        char_of_int((int_of_char c)+n-26)
      else
	if (int_of_char c) + n < 97 then
	  char_of_int((int_of_char c) + n +26)
	else
	  char_of_int((int_of_char c) + n)
    else
      c;;

let rec string_of_list = function
  |[] -> ""
  |e::l -> (Char.escaped e)^string_of_list l ;;

let list_of_string string =
  let length = (String.length string)-1
  in
  let rec aux string = function
    |n when n = length + 1 -> []
    |n -> (string.[n])::(aux string (n+1))
  in
  aux string 0;;

	  (*                   Higher Order                  *)
(*1.2.1*)
let rec map f = function
  |[] -> []
  |e::l -> (f e)::(map f l);;

let uppercase_list list = map (uppercase) list;;

let lowercase_list list = map (lowercase) list;;

(*1.2.2*)
let rec iter f = function;;

(*1.2.3*)
let map2 f list1 list2  = ;;





	  (*****************     Cipher    *******************)
	  (*                  Ceasar Cipher                  *)
(*2.1.1*)
let caesar_encode n s =
  string_of_list (map (rotn n) (list_of_string s));;

(*2.1.2*)
let caesar_decode n s =
  string_of_list (map (rotn (-n)) (list_of_string s));;
  
	  (*                 Vigenere Cipher                 *)




	  (*****************  Build House  *******************)

let sand = ['B' ; 'b' ; 'L' ; 'r' ; 'B'; 'B' ; '\n'];;
let water = ['y' ; 'o' ; 'y' ; 'y' ; 'i'; 'y'; '\n'];;
let brick = ['y' ; 's' ; 's' ; 's' ; 's'; 'e'; '\n'];;
let wood = ['h' ; 'r' ; 'w' ; 'w' ; 'r'; 'h'; '\n'];;
let coca = ['s' ; 'l' ; 'r' ; 'x' ; 'l'; 's'; '\n'];;

let house = [sand ; water ; brick ; wood ; coca];;

let workers = [lowercase ; swap_alpha ; rot13 ; rotn 5 ; rotn 20];;

123-91;;
lower_case 'A';;

