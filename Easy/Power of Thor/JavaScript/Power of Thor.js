[A, B, C, D] = readline().split(' ');
for (; ;) {
    print((D - 0 > B ? D-- && 'N' : D - 0 < B ? ++D && 'S' : '') + (C > A ? C-- && 'W' : C < A ? ++C && 'E' : ''))
}