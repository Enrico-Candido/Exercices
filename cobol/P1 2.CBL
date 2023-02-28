       IDENTIFICATION DIVISION.
       PROGRAM-ID.    PROVA1.
       AUTHOR.        ENRICO CANDIDO.
       INSTALLATION.  FATEC-SP.
       DATE-WRITTEN.  08/10/2020.
       DATE-COMPILED.
       SECURITY. APENAS O AUTOR PODE MODIFICA-LO.    

       ENVIRONMENT DIVISION.
       CONFIGURATION SECTION.
       SOURCE-COMPUTER.   PC.
       OBJECT-COMPUTER.   PC.
       SPECIAL-NAMES.          DECIMAL-POINT IS COMMA.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.

           SELECT PEDIDOS ASSIGN TO DISK
           ORGANIZATION IS LINE SEQUENTIAL.

           SELECT NOTAS ASSIGN TO DISK
           ORGANIZATION IS LINE SEQUENTIAL. 

           SELECT RELNOTA ASSIGN TO DISK.
 
       DATA DIVISION.
       FILE SECTION.
       FD  PEDIDOS
           LABEL RECORD ARE STANDARD
           VALUE OF FILE-ID IS "PEDIDOS.DAT".
       01  REGPEDIDO.
           02 NUMPED          PIC 9(06).
           02 CODPROD         PIC X(06).
           02 CUSTOPROD       PIC 9(04).
           02 IMPFED          PIC 9(03).
           02 IMPEST          PIC 9(03).
           02 IMPMUN          PIC 9(03).
       FD  NOTAS 
           LABEL RECORD ARE STANDARD 
           VALUE OF FILE-ID IS "NOTAS.DAT".
       01  REGPRINT.
           03 PRODUTO         PIC X(06).
           03 PRECFINAL       PIC 9(06).   
       FD  RELNOTA LABEL RECORD OMMITED.
       01  REGNOTA            PIC X(80).

       WORKING-STORAGE SECTION.
       77  FIMARQ             PIC X VALUE SPACES.
       77  CTLIN              PIC 9(02)    VALUE 21.
       77  CTPAG              PIC 9(02)    VALUE ZEROS.       
       01  CAB1.
                 04 FILLER    PIC X(15) VALUE SPACES.
                 04 FILLER    PIC X(40) VALUE 
                               "RELATÓRIO DE NOTAS FICAIS".
                 04 FILLER    PIC X(10) VALUE SPACES.
                 04 FILLER    PIC X(05) VALUE "PAG.".
                 04 PAG       PIC 9(02) VALUE ZEROS. 
       01  CAB2.
                 05 FILLER    PIC X(15) VALUE SPACES.
                 05 FILLER    PIC X(10) VALUE "PRODUTO".
                 05 FILLER    PIC X(30) VALUE SPACES.
                 05 FILLER    PIC X(15) VALUE "PRECO".
                 05 FILLER    PIC X(10) VALUE SPACES.
       01  DET1. 
                 06 FILLER    PIC X(15) VALUE SPACES.
                 06 DET1PROD  PIC X(06) VALUE SPACES.
                 06 FILLER    PIC X(34) VALUE SPACES.
                 06 DET1PREC  PIC X(06) VALUE ZEROS.
                 06 FILLER    PIC X(18) VALUE SPACES.

       PROCEDURE DIVISION.
       ROTINA-PRINCIPAL.
           OPEN INPUT PEDIDOS OUTPUT NOTAS RELNOTA.
           PERFORM LEITURA.
           PERFORM PRINCIPAL 
                   UNTIL FIMARQ EQUAL "*".
           CLOSE PEDIDOS RELNOTA NOTAS.
           STOP RUN.

       LEITURA.
           READ PEDIDOS AT END MOVE "*" TO FIMARQ.         

       PRINCIPAL.           
           PERFORM GRAVA.
           PERFORM IMPRIMIR.
           PERFORM LEITURA.
             

       GRAVA.    
           MOVE CODPROD TO PRODUTO.
           COMPUTE
            PRECFINAL = (CUSTOPROD+IMPFED+IMPEST+IMPMUN)*1,10.
           WRITE REGNOTA.

       IMPRIMIR.
           MOVE PRODUTO   TO DET1PROD.
           MOVE PRECFINAL TO DET1PREC.
           IF  CTLIN GREATER 20
               ADD 1 TO CTPAG
               MOVE CTPAG TO PAG
               WRITE REGPRINT FROM CAB1 AFTER ADVANCING PAGE
               WRITE REGPRINT FROM CAB2 AFTER ADVANCING 2 LINE
               MOVE ZEROS TO CTLIN
           ELSE
               NEXT SENTENCE.
           WRITE REGPRINT FROM DET1 AFTER ADVANCING 1 LINE.
           ADD 1 TO CTLIN.       
