#!/bin/bash
#PBS -q SINGLE
#PBS -l select=1
#PBS -j oe
#PBS -N nocomma

cd $PBS_O_WORKDIR
JAVA_HOME=$HOME/jre1.8.0_65

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_1.test  -filenameout book/output/bookfile3_1.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_1.train  -filenameout book/output/bookfile3_1.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_2.test  -filenameout book/output/bookfile3_2.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_2.train  -filenameout book/output/bookfile3_2.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_3.test  -filenameout book/output/bookfile3_3.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_3.train  -filenameout book/output/bookfile3_3.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_4.test  -filenameout book/output/bookfile3_4.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_4.train  -filenameout book/output/bookfile3_4.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_5.test  -filenameout book/output/bookfile3_5.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_5.train  -filenameout book/output/bookfile3_5.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_6.test  -filenameout book/output/bookfile3_6.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_6.train  -filenameout book/output/bookfile3_6.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_7.test  -filenameout book/output/bookfile3_7.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_7.train  -filenameout book/output/bookfile3_7.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_8.test  -filenameout book/output/bookfile3_8.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_8.train  -filenameout book/output/bookfile3_8.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_9.test  -filenameout book/output/bookfile3_9.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_9.train  -filenameout book/output/bookfile3_9.train

$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_10.test  -filenameout book/output/bookfile3_10.test
$JAVA_HOME/bin/java -Xmx64g -jar frequentformat.jar  -filenamein book/bookfile2_10.train  -filenameout book/output/bookfile3_10.train
