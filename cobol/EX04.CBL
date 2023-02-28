       IDENTIFICATION DIVISION.
       PROGRAM-ID.  PRG04.
       AUTHOR.      ENRICO CANDIDO.

       ENVIRONMENT DIVISION.
       CONFIGURATION SECTION.
       SOURCE-COMPUTER.    PC.
       OBJECT-COMPUTER.    PC.
       SPECIAL-NAMES.      DECIMAL-POINT IS COMMA.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
                    SELECT CADENT ASSIGN TO DISK
                    ORGANIZATION IS LINE SEQUENTIAL.
                    SELECT RELSAI ASSIGN TO DISK.
       
       DATA DIVISION.
       FILE SECTION.
       FD  CADENT
                 LABEL RECORDS STANDARD
                 VALUE OF FILE-ID IS "CADENT.DAT".
       01  REGCAD.
                    02 CODIGO     PIC 9(07).
                    02 NOME       PIC X(25).
                    02 SALARIO    PIC 9(05)V99.
                    02 SEXO       PIC X(01).
       FD  RELSAI LABEL RECORD OMMITED.
       01  REGREL                 PIC X(80).
       WORKING-STORAGE SECTION.
       77  FIMARQ                 PIC X(03) VALUE "NAO".
       77  CTLIN                  PIC 9(02) VALUE 21.
       77  CTPAG                  PIC 9(02) VALUE ZEROS.
       77  TOTAL                  PIC 9(05) VALUE ZEROS.
       77  SAL2                   PIC 9(08)V99 VALUE ZEROS.
       01  PAG.
                 02 FILLER        PIC X(65) VALUE SPACES.
                 02 FILLER        PIC X(04) VALUE "PAG.".
                 02 CTP           PIC ZZ9 VALUE ZEROS.
       01  CAB1.
                 02 FILLER        PIC X(15) VALUE SPACES.
                 02 FILLER        PIC X(65) VALUE
                              "LISTAGEM DOS CLIENTES DO SEXO FEMININO".
       01  CAB2. 
                 02 FILLER        PIC X(20) VALUE SPACES.
                 02 FILLER        PIC X(60) VALUE
                              "COM SALARIOS SUPERIORES A 5.000,00".
       01  QUEBRA.
                 02 FILLER         PIC X(80) VALUE SPACES.
       01  CAB3. 
                 02 FILLER         PIC X(05) VALUE SPACES.
                 02 FILLER         PIC X(10) VALUE "CODIGO".
                 02 FILLER         PIC X(10) VALUE SPACES.
                 02 FILLER         PIC X(35) VALUE "NOME".
                 02 FILLER         PIC X(20) VALUE "SALARIO".
       01  DETALHE.
                 02 FILLER         PIC X(05) VALUE SPACES.
                 02 COD            PIC 999.999.9 VALUE ZEROS.
                 02 FILLER         PIC X(03) VALUE SPACES.
                 02 NOM            PIC X(40) VALUE SPACES.
                 02 SAL            PIC ZZ.ZZ9,99 VALUE ZEROS.
       01  TOTALCLI.    
                 02 FILLER         PIC X(30) VALUE
                                  "TOTAL DE CLIENTES IMPRESSOS:".
                 02 TOTCLI         PIC ZZ.ZZ9 VALUE ZEROS.   
       01  TOTALSAL.
                 02 FILLER         PIC X(30) VALUE
                                  "TOTAL DE SALARIO:".
                 02 TOTSAL         PIC ZZ.ZZZ.ZZ9,99 VALUE ZEROS.

       PROCEDURE DIVISION.
       PGM-PRINCIPAL.
                 OPEN INPUT CADENT
                      OUTPUT RELSAI.
                 PERFORM LEITURA.
                 PERFORM PRINCIPAL
                             UNTIL FIMARQ EQUAL "SIM".
                 CLOSE CADENT RELSAI. 
                 STOP RUN.
       LEITURA.
                 READ CADENT
                            AT END
                                   MOVE "SIM" TO FIMARQ
                 MOVE TOTAL TO TOTCLI
                 MOVE SAL2 TO TOTSAL
                 WRITE REGREL FROM TOTALCLI AFTER ADVANCING 3 LINE
                 WRITE REGREL FROM TOTALSAL AFTER ADVANCING 1 LINE.
       IMPRIME. 
                 MOVE CODIGO TO COD.
                 MOVE NOME TO NOM.
                 MOVE SALARIO TO SAL.
              IF CTLIN GREATER 20
                 ADD 1 TO CTPAG
                 MOVE SPACES TO REGREL
                 MOVE CTPAG TO CTP
                 WRITE REGREL AFTER ADVANCING PAGE
                 WRITE REGREL FROM PAG AFTER ADVANCING 1 LINE
                 WRITE REGREL FROM QUEBRA AFTER ADVANCING 1 LINE  
                 WRITE REGREL FROM CAB1 AFTER ADVANCING 1 LINE
                 WRITE REGREL FROM CAB2 AFTER ADVANCING 1 LINE
                 WRITE REGREL FROM QUEBRA AFTER ADVANCING 1 LINE   
                 WRITE REGREL FROM CAB3 AFTER ADVANCING 1 LINE
                 WRITE REGREL FROM QUEBRA AFTER ADVANCING 1 LINE
                 MOVE 1 TO CTLIN.
              IF SEXO EQUAL "F" AND SALARIO GREATER 4999,99
                 MOVE DETALHE TO REGREL
                 ADD 1 TO TOTAL
                 COMPUTE SAL2 = SAL2 + SALARIO
                 WRITE REGREL FROM DETALHE AFTER ADVANCING 1 LINE
                 ADD 1 TO CTLIN.
       PRINCIPAL.
               PERFORM IMPRIME.
               PERFORM LEITURA.























       