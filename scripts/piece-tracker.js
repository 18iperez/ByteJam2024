function CollectPiece(n){
    if (n == 0){
        var Collected = 0;
        var Piece1 = 1;
        var Piece2 = 1;
        var Piece3 = 1;
    }
    if (n == 1) {
        Collected += Piece1;
        Piece1 = 0
    }
    else {
        if (n == 2) {
            Collected += Piece2;
            Piece2 = 0
        } else {
            if (n == 3) {
                Collected += Piece3;
                Piece3 = 0
            } 
        }
    }
    return Collected
}

function AddPiece(){

}