(************************************************************)
(*                     Game of life                         *)
(************************************************************)

(* graphics *)

#load "graphics.cma" ;;
open Graphics ;;

let open_window size =
  open_graph(" " ^ string_of_int size ^ "x" ^ string_of_int (size+20));;

let grey = rgb 127 127 127 ;;

let cell_color = function
  | 0 -> white
  | _ -> black ;;

let cell_size = 10 ;;

(* original game of life definitions *)

let new_cell = 1 ;;

let empty = 0 ;;

let is_alive cell = cell <> empty ;;


(*******************   FROM TP 3 *********************)
(*   insert here needed simple functions on lists    *)

let rec length  = function
  |[]   -> 0
  |e::l -> 1 + length l ;;

let init_list n x =
  let rec init_aux x = function
    |0->[]
    |n->x::(init_aux x (n-1))
  in
  init_aux x n;;


  let nth i =
  if i >= 0 then
    let rec aux (i,y) = function
      |[]              -> failwith "nth: list is too short"
      |e::l when y = i -> e
      |e::l            -> aux (i,y+1) l
    in
    aux (i,0)
  else
    invalid_arg "i must be a positive number";;

(*******************   Toolbox *********************)
(*             list list functions                 *)
  
(*1.1*)
  let gen_board (l,c) x =
    init_list l (init_list c x);;

(*1.2*)
let get_cell (x,y) board =
  (nth y (nth x board));;

(*1.3*)
let put_cell value (x,y) board =
  let rec put n x = function
    |[]->[]
    |_::l when n = 0 -> put (n-1) x (x::l)
    |e::l -> e::put (n-1) x l
  in
  put x (put y value (nth x board)) board;;

(*1.4*)
let rec count_neighbours (x,y) board (l,c) =
  if x<0 || y<0 || x>c || y>l then
    invalid_arg "at least one parameter is out of bounds"
  else
    let rec aux_1 (x,y) (l,c) ny nx = function
      |[]|[[]] when is_alive (get_cell (x,y) board)-> 0-1
      |[]|[[]] -> 0
      |[]::l2 -> aux_1 (x,y) (l,c) 0 (nx+1) l2
      |(e::l1)::l2 when ny>y-2 && ny<y+2 && is_alive e && nx>x-2 && nx<x+2 -> 1+(aux_1 (x,y) (l,c) (ny+1) nx (l1::l2))
      |(e::l1)::l2 -> aux_1 (x,y) (l,c) (ny+1) nx (l1::l2)
    in
    aux_1 (x,y) (l,c) 0 0 board;;



(************************************************************)
(*                  graphics                                *)
(*        from the board to the graphic window              *)
(*1.1*)
let draw_cell (x,y) size color =
  set_color color ;
  fill_rect (x+1) (y+1) size size ;
  set_color grey ;
  draw_rect (x+1) (y+1) size size ;;

(*1.2*)
let draw_board board size =
  clear_graph() ; 
  let rec aux_1 size nx ny = function
    |[[]] | [] -> draw_rect 0 0 1 1
    |[]::l2 -> aux_1 size (nx+size) 0 l2
    |(e::l1)::l2 -> draw_cell (nx,ny) size (cell_color e) ; aux_1 size nx (ny+size) (l1::l2)
  in
  aux_1 size 0 0 board ;;



(************************************************************)
(*                     Game of life                         *)
(************************************************************)

(*rules*)
let rules0 cell near =
  if near = 3 && cell = 0 then
    new_cell
  else
    if near <> 2 && near <> 3 && cell = 1 then
      empty
    else
      cell ;;

(*1*)
let rec seed_life board size nb_cell = match nb_cell with
  |0 -> board
  |_ -> put_cell 1 ((Random.int size),(Random.int size)) (seed_life board size (nb_cell-1));;

(*2*)
let new_board size nb_cell = seed_life (gen_board (size,size) empty) size nb_cell;;

(*3*)
let next_generation board =


    let rec antiopti board size2 nx size =
      if size2 = 0 then
	[]
      else
	
	let rec aux nx ny board size = match size with
	  |_ when ny = size -> []
	  |_ -> ((rules0 (get_cell (nx,ny) board) (count_neighbours (nx,ny) board (size,size))))::(aux nx (ny+1) board size)
	in
	( aux (nx+1) 0 board size)::(antiopti board (size2-1)(nx+1) size )
    in
    antiopti board (length board) (-1) (length board);;

(*4*)
let rec game board = function
  |0-> draw_board board cell_size
  |n-> draw_board board cell_size ; game (next_generation board) (n-1);;


(*5*)
let new_game size nb_cell n =
  open_window (size*size + 40) ;
  game (new_board size nb_cell) n;;



(*Bonus*)
let remaining board = if board = gen_board ((length board),(length board)) empty then
    1=0
  else 1=1;;

let new_game size nb_cell n =
  open_window (size*size + 40) ;
  let board = new_board size nb_cell in 
  game board n;
  let rec to_infinity board =
    if (remaining board) = false then
    game board 0
  else
   ( game board (n/n) ; to_infinity (next_generation board) )
     
  in
  to_infinity board;;
new_game 25 200 1000;;
(*open_window 500;;
draw_board [[0;0;0;0;0;0;0;0;0;0];[0;0;0;0;0;0;0;0;0;0];[0;1;1;0;0;0;0;0;0;0];[0;0;0;1;0;0;1;1;0;0];[0;0;0;0;1;0;0;0;0;0];
	     [0;0;0;0;1;0;0;0;0;0];[0;0;0;1;0;0;1;1;0;0];[0;1;1;0;0;0;0;0;0;0];[0;0;0;0;0;0;0;0;0;0];[0;0;0;0;0;0;0;0;0;0]] 10;;*)

(*new_game 40 300 1000;;*)

(*open_window 400;;
game [[1;1;1;1;1;1;1;1;1;1];[0;0;0;0;0;0;0;0;0;0];[1;0;1;0;1;0;1;0;1;0];[0;1;0;1;0;1;0;1;0;1];[0;0;0;0;0;0;0;0;0;0];
	     [1;1;1;1;1;1;1;1;1;1];[0;0;0;0;0;0;0;0;0;0];[1;0;1;0;1;0;1;0;1;0];[0;1;0;1;0;1;0;1;0;1];[0;0;0;0;0;0;0;0;0;0]] 6 ;;*)
(*new_game 40 500 1;;*)
