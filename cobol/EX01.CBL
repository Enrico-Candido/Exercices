       IDENTIFICATION DIVISION.
       PROGRAM-ID.  PRG01.
       AUTHOR.      ENRICO CANDIDO.

       ENVIRONMENT DIVISION.
       CONFIGURATION SECTION.
       SOURCE-COMPUTER.        PC.
       OBJECT-COMPUTER.        PC.
       SPECIAL-NAMES.          DECIMAL-POINT IS COMMA.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT PEDIDOMA ASSIGN   DISK
           ORGANIZATION IS LINE SEQUENTIAL.
           SELECT RELPEDMA ASSIGN   DISK.
           SELECT ARQSORT  ASSIGN   DISK.

       DATA DIVISION.
       FILE SECTION.
       FD  PEDIDOMA
             LABEL RECORDS STANDARD
             VALUE  OF  FILE-ID   IS  "PEDIDOMA.DAT".
       01  REGPEDMA.
             05  CODPR         PIC X(05).
             05  CODMA         PIC X(01).
             05  DESCPR        PIC X(10).

       FD  RELPEDMA LABEL RECORD OMMITED.
       01  REGRELPEDMA         PIC X(80).
               
       SD  ARQSORT.
       01  REGSORT.
             05  CODP          PIC X(05).
             05  CODM          PIC X(01).
             05  DESCP         PIC X(10).

       WORKING-STORAGE SECTION. 
       77  FIM                 PIC X(03) VALUE "NAO".
       77  CTLIN               PIC 99    VALUE 21.
       01  CAB0.
                 04 FILLER     PIC X(80) VALUE SPACES.
       01  CAB1.
                 04 FILLER     PIC X(15) VALUE SPACES.
                 04 FILLER     PIC X(30) VALUE "RELATORIO DE PEDIDOS".
                 04 FILLER     PIC X(15) VALUE SPACES.
                 04 FIILER     PIC X(04) VALUE "PAG.".
                 04 CTPAG      PIC 9(02) VALUE ZEROS.
       01  CAB2.
                 04 FILLER     PIC X(10) VALUE SPACES.
                 04 FILLER     PIC X(10) VALUE "MARCA".
                 04 FILLER     PIC X(05) VALUE SPACES.
                 04 FILLER     PIC X(10) VALUE "PRODUTO".
                 04 FILLER     PIC X(05) VALUE SPACES.
                 04 FILLER     PIC X(15) VALUE "DESCRICAO".
       01  DETALHE.
                 04 FILLER     PIC X(10) VALUE SPACES.
                 04 MARCA      PIC X(01) VALUE ZEROS.
                 04 FILLER     PIC X(14) VALUE SPACES.
                 04 PRODUTO    PIC X(05) VALUE ZEROS.
                 04 FILLER     PIC X(10) VALUE SPACES.
                 04 DESCRICAO  PIC X(10) VALUE SPACES.
  
       PROCEDURE DIVISION.
       ROTINA-SORT.
           SORT   ARQSORT   ASCENDING   KEY   CODM
                          USING     PEDIDOMA
                          GIVING    PEDIDOMA.
       PRINCIPAL-PROG.
           OPEN INPUT  PEDIDOMA OUTPUT RELPEDMA.
           PERFORM LER.
           PERFORM PRINCIPAL
                   UNTIL FIM EQUAL "SIM".
           CLOSE PEDIDOMA RELPEDMA.
           STOP RUN.

       LER.
            READ PEDIDOMA 
                         AT END
                               MOVE "SIM" TO FIM.
       PRINCIPAL.
                 PERFORM PRINT.
                 PERFORM LER.
       PRINT.
           IF  CTL GREATER 20
               MOVE SPACES TO REGRELPEDMA
               WRITE REGRELPEDMA AFTER ADVANCING PAGE
               MOVE 1 TO CTL
               ADD 1 TO CTPAG
               WRITE REGRELPEDMA FROM CAB0 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDMA FROM CAB1 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDMA FROM CAB0 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDMA FROM CAB0 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDMA FROM CAB2 AFTER ADVANCING 1 LINE
           ELSE 
               NEXT SENTENCE.
           MOVE CODMA TO MARCA.
           MOVE CODPR TO PRODUTO.
           MOVE DESCPR TO DESCRICAO.
           WRITE REGRELPEDMA FROM DETALHE AFTER ADVANCING 1 LINE.
           ADD 1 TO CTL.             