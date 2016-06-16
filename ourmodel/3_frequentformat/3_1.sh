#!/bin/bash

cd $PBS_O_WORKDIR
echo "book"
sed -i.bak s/ROOT/root/g book/*.*
rm book/*.bak

echo "dvd"
sed -i.bak s/ROOT/root/g dvd/*.*
rm dvd/*.bak

echo "electronic"
sed -i.bak s/ROOT/root/g electronic/*.*
rm electronic/*.bak

echo "kit"
sed -i.bak s/ROOT/root/g kit/*.*
rm kit/*.bak

echo "finished"

