**Homework - Databases Overview**

What database models do you know?


 1. *Relational Model - a table based model*
 2. *Object-oriented Model*

**Which are the main functions performed by a Relational Database Management System (RDBMS)?**

*The main function is storing and retrieving data as requested by other software applications—which may run either on the same computer or on another computer across a network (including the Internet).*

**Define what is "table" in database terms.**

*A table is a collection of related data held in a structured format within a database.It consist of columns and rows. In Relational Databases a table is a set of data elements using a model of vertical columns which are identifiable by names  and horizontal rows*

**Explain the difference between a primary and a foreign key.**

*Primary key is The main key of the table while the foreign key points the relation of the element to another table*

**Explain the different kinds of relationships between tables in relational databases.**

 1. One-to-Many Relationship
 2. Many-to-Many Relationships
 3. One-to-One Relationships

**When is a certain database schema normalized?**

*A database is normalized when redundant and repeatable information in a table is as low as possible.*
*There are four stages of normalization*

**What are the advantages of normalized databases?**

*A normalized database is easier to use and maintain, it saves disk space nad makes the the database more reliable *

**What are database integrity constraints and when are they used?**

*Database integrity constraints obligates the user of the database to use it the way it should - for example Cannot set NULL to a primary key or cannot set a field in a table with a string value if it is said that the value type is int.  The data in a database must be right and in good condition. There are four types of constraints in databases:*

1. Domain integrity
2. Entity integrity
3. Referntial integrity
4. Foreign key integrity


[Integrity constraints useful site](http://www2.amk.fi/digma.fi/www.amk.fi/opintojaksot/0303011/1146161367915/1146161783414/1146163065754/1146163167961.html)

**Point out the pros and cons of using indexes in a database.**

PROS:
*Searching for indexes is way faster than searching strings for example *

CONS:
*Using indexes slows down inserts, updates and deletes because the database engine does not have to write the data only, but the index, too. An index need space on hard disk*

**What's the main purpose of the SQL language?**

*The main purpose of  SQL  (Structural Query Language) is managing the data held  in a relational database management system. It is, a declarative language and also includes procedural elements. Can be used for inserting,selecting,updating and creating. *

**What are transactions used for? Give an example.**

*A transaction generally represents any change in database. Transactions in a database environment have two main purposes:*

* To provide reliable units of work that allow correct recovery from failures and keep a database consistent even in cases of system failure, when execution stops (completely or partially) and many operations upon a database remain uncompleted, with unclear status.
 
* To provide isolation between programs accessing a database concurrently. If this isolation is not provided, the programs' outcomes are possibly erroneous.

**What is a NoSQL database? Explain the classical non-relational data models.**

*NoSQl are non-relational, distributed, open-source and horizontally scalable DB systems from new generation.*

**Give few examples of NoSQL databases and their pros and cons.**

*Top five NoSQL databases at the moment are*

* MongoDB
 * MongoDB is a document-oriented database that natively supports JSON format. It is extremely easy to use and operate so it is very popular with developers and doesn’t require a database administrator (DBA) to bootstrap. MongoDB is quite functionally robust and allows for flexible replication for sharding across nodes. With MongoDB, there is multi-version concurrency control for keeping older versions of data available to ensure consistency in complex transactions.

* Redis
 * Redis is one of the fastest datastores available today. An open source, in-memory and NoSQL database known for its speed and performance, Redis has become popular with developers and has a growing and vibrant community. It features several data types that make implementing various functionalities and flows extremely simple.

* Cassandra
 * Created at Facebook, Cassandra has emerged as a useful hybrid of a column-oriented database with a key-value store. Grouping families gives the familiar feeling of tables and provides good replication and consistency for easy linear scaling. Cassandra is most effective when used for managing really big volumes of data (the kind that don’t fit in a single server), such as Web/click analytics and measurements from the Internet of Things – writing to Cassandara is extremely fast. It provides a familiar interface (CQL, reminiscent of SQL) and the learning curve isn’t too steep for users. Cassandra also comes with tunable consistency settings.
