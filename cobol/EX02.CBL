       IDENTIFICATION DIVISION.
       PROGRAM-ID.  PRG02.
       AUTHOR.      ENRICO CANDIDO.

       ENVIRONMENT DIVISION.
       CONFIGURATION SECTION.
       SOURCE-COMPUTER.        PC.
       OBJECT-COMPUTER.        PC.
       SPECIAL-NAMES.          DECIMAL-POINT IS COMMA.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT PEDIDOCP ASSIGN   DISK
           ORGANIZATION IS LINE SEQUENTIAL.
           SELECT RELPEDCP ASSIGN   DISK.
           SELECT ARQSORT  ASSIGN   DISK.

       DATA DIVISION.
       FILE SECTION.
       FD  PEDIDOCP
             LABEL RECORDS STANDARD
             VALUE  OF  FILE-ID   IS  "PEDIDOCP.DAT".
       01  REGPEDCP.
             05  CODPR         PIC X(05).
             05  CODMA         PIC X(01).
             05  DESCPR        PIC X(10).

       FD  RELPEDCP LABEL RECORD OMMITED.
       01  REGRELPEDCP         PIC X(80).
               
       SD  ARQSORT.
       01  REGSORT.
             05  CODP          PIC X(05).
             05  CODM          PIC X(01).
             05  DESCP         PIC X(10).

       WORKING-STORAGE SECTION. 
       77  FIMARQ              PIC X(03) VALUE "NAO".
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
           SORT   ARQSORT   ASCENDING   KEY   CODP
                          USING     PEDIDOCP
                          GIVING    PEDIDOCP.
       PRINCIPAL-PROG.
           OPEN INPUT PEDIDOCP OUTPUT RELPEDCP.
           PERFORM LER.
           PERFORM PRINCIPAL
                   UNTIL FIMARQ EQUAL "SIM".
           CLOSE PEDIDOCP RELPEDCP.
           STOP RUN.
           
       LER.
            READ PEDIDOCP 
                         AT END
                               MOVE "SIM" TO FIMARQ.
       PRINCIPAL.
                 PERFORM IMPRIME.
                 PERFORM LER.
       IMPRIME.
           IF  CTLIN GREATER 20
               MOVE SPACES TO REGRELPEDCP
               WRITE REGRELPEDCP AFTER ADVANCING PAGE
               MOVE 1 TO CTLIN
               ADD 1 TO CTPAG
               WRITE REGRELPEDCP FROM CAB0 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDCP FROM CAB1 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDCP FROM CAB0 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDCP FROM CAB0 AFTER ADVANCING 1 LINE
               WRITE REGRELPEDCP FROM CAB2 AFTER ADVANCING 1 LINE
           ELSE 
               NEXT SENTENCE.
           MOVE CODMA TO MARCA.
           MOVE CODPR TO PRODUTO.
           MOVE DESCPR TO DESCRICAO.
           WRITE REGRELPEDCP FROM DETALHE AFTER ADVANCING 1 LINE.
           ADD 1 TO CTLIN.              