       IDENTIFICATION DIVISION.
       PROGRAM-ID.  PRG03.
       AUTHOR.      ENRICO CANDIDO.

       ENVIRONMENT DIVISION.
       CONFIGURATION SECTION.
       SOURCE-COMPUTER.    PC.
       OBJECT-COMPUTER.    PC.
       SPECIAL-NAMES.          DECIMAL-POINT IS COMMA.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT CADSOC1 ASSIGN TO DISK
           ORGANIZATION IS LINE SEQUENTIAL.
           SELECT CADSOC2 ASSIGN TO DISK
           ORGANIZATION IS LINE SEQUENTIAL.
           SELECT RELSOC ASSIGN TO DISK.

       DATA DIVISION.
       FILE SECTION. 
       FD  CADSOC1
           LABEL RECORDS ARE STANDARD
           VALUE OF FILE-ID IS "CADSOC1.DAT".
       01  REGCAD1.
           02 CODPAG1       PIC 9(02).
           02 NUMSOC1       PIC 9(06).
           02 NOMSOC1       PIC X(20).
           02 VAL1          PIC 9(09)V99.
       FD  CADSOC2
           LABEL RECORDS ARE STANDARD 
           VALUE OF FILE-ID IS "CADSOC2.DAT".
       01  REGCAD2.
           02 NUMSOC2       PIC 9(06).
           02 NOMSOC2       PIC X(20).
           02 VAL2          PIC 9(09)V99.
       FD  RELSOC LABEL RECORD OMMITED.
       01  REGREL           PIC X(80).

       WORKING-STORAGE SECTION.
       77  FIMARQ           PIC X(03) VALUE "NAO".
       77  CTLIN            PIC 99    VALUE 31.
       77  ATRAS            PIC 9(05) VALUE ZEROS.
       77  CTPAG            PIC 9(02) VALUE ZEROS.
       01  CAB0.
                 03 FILLER  PIC X(65) VALUE SPACES.
                 03 FILLER  PIC X(05) VALUE "PAG.".
                 03 CTP     PIC Z9    VALUE ZEROS.
       01  BREAK.
                 03 FILLER  PIC X(80) VALUE SPACES.
       01  CAB1.
                 03 FILLER  PIC X(20) VALUE SPACES.
                 03 FILLER  PIC X(60) VALUE 
                                      "RELACAO DE SOCIOS ATRASADOS".
       01  CAB2.
                 03 FILLER  PIC X(05) VALUE SPACES.
                 03 FILLER  PIC X(20) VALUE "NUMERO DO SOCIO".
                 03 FILLER  PIC X(25) VALUE "NOME DO SOCIO".
                 03 FILLER  PIC X(25) VALUE "VALOR DO PAGAMENTO".
       01  DETALHE.
                 03 FILLER  PIC X(05) VALUE SPACES.
                 03 NUM     PIC 999.999 VALUE ZEROS.
                 03 FILLER  PIC X(13) VALUE SPACES.
                 03 NOM     PIC X(30) VALUE SPACES.
                 03 PAG     PIC ZZZ.ZZZ.ZZ9,99 VALUE ZEROS.
       01  ATRASADOS.
                 03 FILLER  PIC X(27) VALUE
                            "TOTAL DE SOCIOS ATRASADOS:".
                 03 ATRASA  PIC ZZ.ZZ9 VALUE ZEROS.

       PROCEDURE DIVISION.
       PRINCIPAL-PROG.
           OPEN INPUT CADSOC1 OUTPUT CADSOC2 RELSOC.
           PERFORM LEITURA.
           PERFORM PRINCIPAL
                   UNTIL FIMARQ EQUAL "SIM".
           CLOSE CADSOC1 CADSOC2 RELSOC.
           STOP RUN.
 
       LEITURA.
                      READ CADSOC1
                                  AT END
                                         MOVE "SIM" TO FIMARQ
                   MOVE ATRAS TO ATRASA
                   WRITE REGREL FROM ATRASADOS AFTER ADVANCING 3 LINES.
       PRINCIPAL. 
                      PERFORM PRINT.
                      PERFORM LEITURA.
       PRINT.
           IF (CODPAG1 EQUAL 1)
               MOVE NUMSOC1 TO NUMSOC2 
               MOVE NOMSOC1 TO NOMSOC2
               MOVE VAL1  TO VAL2
               WRITE REGCAD2 AFTER ADVANCING 1 LINE.
           IF (CTLIN GREATER 30)
               MOVE SPACES TO REGREL
               WRITE REGREL AFTER ADVANCING PAGE
               MOVE 1 TO CTLIN
               ADD 1 TO CTPAG
               MOVE CTPAG TO CTP
               WRITE REGREL FROM CAB0 AFTER ADVANCING 1 LINE
               WRITE REGREL FROM BREAK AFTER ADVANCING 1 LINE
               WRITE REGREL FROM BREAK AFTER ADVANCING 1 LINE
               WRITE REGREL FROM CAB1 AFTER ADVANCING 1 LINE      
               WRITE REGREL FROM BREAK AFTER ADVANCING 1 LINE   
               WRITE REGREL FROM BREAK AFTER ADVANCING 1 LINE
               WRITE REGREL FROM CAB2 AFTER ADVANCING 1 LINE
               WRITE REGREL FROM BREAK AFTER ADVANCING 1 LINE.
           IF (CODPAG1 EQUAL 2) 
               MOVE NUMSOC1 TO NUM
               MOVE NOMSOC1 TO NOM
               MOVE VAL1  TO PAG
               ADD 1 TO CTLIN
               ADD 1 TO ATRAS
               WRITE REGREL FROM DETALHE AFTER ADVANCING 1 LINE.