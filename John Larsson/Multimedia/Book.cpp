#include "Book.h"

Book::Book(string,string,string,string,string,int){
	this->author=author;
	this->titel=titel;
	this->type=type;
	this->time=time;
	this->date=date;
	this->pages=pages;
}

Book::~Book(void)
{
}

void Book::setMultimedia(string type,string author,string titel,string date,string time, int pages){
	this->author=author;
	this->titel=titel;
	this->type=type;
	this->time=time;
	this->date=date;
	this->pages=pages;
}

ostream& operator<<(ostream &out,Book &book){
	out<<"("<<book.type<<","<<book.author<<","<<book.titel<<","<<book.pages<<","<<book.date<<","<<book.time<<")";
	return out;
}

istream& operator>>(istream &in,Book &book){
	char c;
	in>>skipws;
	getline(in,book.author,',');
	in>>skipws;
	getline(in,book.titel,',');
	in>>skipws;
	in>>book.pages;
	in>>c;
	in>>skipws;
	getline(in,book.date,',');
	in>>skipws;
	getline(in,book.time,')');
	in>>skipws;
	return in;
}