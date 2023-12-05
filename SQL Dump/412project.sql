--
-- PostgreSQL database dump
--

-- Dumped from database version 15.4
-- Dumped by pg_dump version 15.4

-- Started on 2023-12-02 21:36:41

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 218 (class 1259 OID 25464)
-- Name: comppart; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.comppart (
    cp_comp_id integer NOT NULL,
    cp_pid character varying(64) NOT NULL
);


ALTER TABLE public.comppart OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 25444)
-- Name: computer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.computer (
    c_oid integer NOT NULL,
    c_comp_id integer NOT NULL,
    c_type character varying(16),
    c_weight double precision
);


ALTER TABLE public.computer OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 25425)
-- Name: customer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.customer (
    cu_cid integer NOT NULL,
    cu_name character varying(32),
    cu_email character varying(32),
    cu_address character varying(64),
    cu_phone character varying(16),
    cu_comment character varying(512)
);


ALTER TABLE public.customer OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 25432)
-- Name: orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orders (
    o_oid integer NOT NULL,
    o_cid integer,
    o_price numeric(15,2),
    o_date date,
    o_type character varying(16),
    o_status character varying(16),
    o_comment character varying(512)
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 25459)
-- Name: part; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.part (
    p_pid character varying(64) NOT NULL,
    p_name character varying(64),
    p_quantity integer,
    p_type character varying(16),
    p_manufacturer character varying(32),
    p_price numeric(15,2)
);


ALTER TABLE public.part OWNER TO postgres;

--
-- TOC entry 3348 (class 0 OID 25464)
-- Dependencies: 218
-- Data for Name: comppart; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.comppart (cp_comp_id, cp_pid) FROM stdin;
1	BX8071514900K
1	GeForce RTX 4090 GAMING X TRIO 24G
1	WD121KRYZ
1	F4-2400C14Q2-128GRK
1	WDS400T2X0E
1	MKNUFDVU240GB
2	BX8071513900KS
2	GV-N4090GAMING OC-24GD
2	WD101KRYZ
2	F4-3200C14Q-64GTZ
2	WDS200T2X0E
2	MKNUFDVU60GB
3	BX8071514700K
3	RTX 4090 SUPRIM Liquid X 24G
3	WD6002FRYZ
3	BLS4K8G4D240FSA
3	MZ-V9P2T0B
3	MKNUFDVU120GB
4	BX8071513900KF
4	RTX 4090 SUPRIM X 24G
4	WD8003FRYZ
4	BLE4K8G4D36BEEAK
4	WDS200T1X0E
4	CMFVYGTX3-256GB
5	BX8071513900K
5	TUF-RTX4090-24G-GAMING
5	WD6002FFWX
5	F4-3200C14Q-32GFX
5	WDS100T2X0E
5	CMFVYGTX3-128GB
6	BX8071513700KF
6	G408016SX
6	WD6002FZWX
6	F4-3200C15Q-64GTZ
6	SSDPED1D280GASX
6	SDCZ88-128G
7	BX8071513700K
7	GV-N4080GAMING OC-16GD
7	0S03839
7	CMD64GX4M4B3000C15
7	SSDPE21D280GASX
7	SDCZ80-064G
8	BX8071513900F
8	RTX 4080 16GB GAMING X TRIO
8	WD8002FRYZ
8	CMK32GX4M2Z3600C18
8	CT2000P5PSSD8
8	MUF-64BB/US
9	BX8071513900
9	RTX 4080 16GB VENTUS 3X OC
9	WD1000DHTZ
9	F4-3600C16D-16GTZ
9	MZ-V8P2T0B
9	SDCZ80-032G
10	100-100000908WOF
10	TUF-RTX4080-O16G-GAMING
10	ST3000NC002
10	F4-3200C14D-16GFX
10	SSDPED1D960GAX1
10	MKNUFDVU240GB
11	BX8071514900K
11	ZT-D40810B-10P
11	WD121KRYZ
11	F4-2400C14Q2-128GRK
11	SSDPED1D480GASX
11	MKNUFDVU60GB
12	BX8071513900KS
12	GeForce RTX 4070 Ti VENTUS 3X 12G OC
12	WD101KRYZ
12	F4-3200C14Q-64GTZ
12	SSDPE21D480GASX
12	MKNUFDVU120GB
13	BX8071514700K
13	GV-N407TEAGLE OC-12GD
13	WD6002FRYZ
13	BLS4K8G4D240FSA
13	WDS400T2X0E
13	CMFVYGTX3-256GB
14	BX8071513900KF
14	GV-N407TGAMING OC-12GD
14	WD8003FRYZ
14	BLE4K8G4D36BEEAK
14	WDS200T2X0E
14	CMFVYGTX3-128GB
15	BX8071513700KF
15	ZT-D40810B-10P
15	WD6002FZWX
15	F4-3600C16D-16GTZ
15	MZ-V9P2T0B
15	MKNUFDVU60GB
\.


--
-- TOC entry 3346 (class 0 OID 25444)
-- Dependencies: 216
-- Data for Name: computer; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.computer (c_oid, c_comp_id, c_type, c_weight) FROM stdin;
1	1	Micro ATX	37.203
2	2	Mini ITX	37.1848
3	3	ATX	40.7079
4	4	Micro ATX	35.8795
5	5	Mini ITX	38.6185
6	6	ATX	44.2679
7	7	Micro ATX	40.847
8	8	Mini ITX	30.6237
9	9	ATX	45.0774
10	10	Micro ATX	38.5043
11	11	Mini ITX	37.7977
12	12	ATX	39.4663
13	13	Micro ATX	34.3577
14	14	Mini ITX	43.2914
15	15	ATX	45.8596
16	16	Micro ATX	37.203
17	17	Mini ITX	37.1848
18	18	ATX	40.7079
19	19	Micro ATX	35.8795
20	20	Mini ITX	38.6185
\.


--
-- TOC entry 3344 (class 0 OID 25425)
-- Dependencies: 214
-- Data for Name: customer; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.customer (cu_cid, cu_name, cu_email, cu_address, cu_phone, cu_comment) FROM stdin;
1	Leon Tran	lltran@asu.edu	1151 N FOREST AVE TEMPE AZ 85281	518-5008	The creator of this .csv file and table!
2	Teddy Golden	teddygolden@example.com	815 N 52ND ST PHOENIX AZ 85008	555-4315	Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque quis pellentesque ex. Morbi sed faucibus orci. Donec facilisis orci nec
3	Charley Anthony	charleyanthony@example.com	201 E DESERT HILLS DR PHOENIX AZ 85086	555-7243	pretium gravida. Integer rutrum neque mauris, nec consectetur nibh blandit eget. Etiam ut leo nec neque placerat vehicula. Nullam ut
4	Erin Kirby	erinkirby@example.com	300 W DESERT HILLS DR PHOENIX AZ 85086	555-8493	hendrerit erat. Nulla quis erat nec mauris convallis bibendum bibendum vitae justo. Donec a tortor vitae ipsum pharetra feugiat.
5	Abby Becker	abbybecker@example.com	2000 W AGRARIAN HILLS DR QUEEN CREEK AZ 85142	555-6050	Praesent porttitor ornare arcu a feugiat.
6	Leighton Bean	leightonbean@example.com	1903 N COUNTRY CLUB DR MESA AZ 85201	555-0360	Curabitur ex lorem, blandit a odio sit amet, semper tempus arcu. Fusce rutrum non augue non sagittis. Praesent nec magna orci. Nunc
7	Nana Mooney	nanamooney@example.com	1900 E 5TH AVE MESA AZ 85204	555-1967	faucibus ex arcu, id aliquam arcu porttitor in. Aenean euismod ut enim eleifend consequat. Cras augue ex, laoreet non erat vel, viverra
8	Nevaeh Wilkins	nevaehwilkins@example.com	9601 E NATAL AVE MESA AZ 85209	555-5127	fringilla orci. Donec ultricies lobortis velit id sagittis. Suspendisse egestas viverra nulla, nec gravida quam viverra ac. Proin eu ligula in
9	Jade Raymond	jaderaymond@example.com	6625 S LA ROSA DR TEMPE AZ 85283	555-7042	risus mollis dignissim at at neque. Etiam sed metus eget quam rutrum ultrices. Vestibulum dapibus aliquam nisl. Donec bibendum,
10	Dante Tapia	dantetapia@example.com	36200 W BUCKEYE RD TONOPAH AZ 85354	555-0593	enim at pretium blandit, tellus diam hendrerit nibh, quis pellentesque ipsum lorem placerat elit. Nunc ut felis mi.
11	Rohan Barrett	rohanbarrett@example.com	1700 E LARKSPUR DR PHOENIX AZ 85022	555-2301	Donec interdum odio sapien, at pellentesque quam iaculis quis. Nam et dolor massa. Curabitur commodo neque id felis rhoncus, varius
12	Kane Kirk	kanekirk@example.com	201 W WICKIEUP LN PHOENIX AZ 85027	555-6209	commodo urna dignissim. Nunc eget sem leo. Sed in tincidunt magna. Cras maximus massa in libero tincidunt, a ultricies justo mollis.
13	Elliot Odonnell	elliotodonnell@example.com	2701 E GROVERS AVE PHOENIX AZ 85032	555-7980	Donec tempus mi sed hendrerit malesuada. Nam eget neque tempus, malesuada tortor fermentum, molestie quam. Nam laoreet quam
14	Mae Welsh	maewelsh@example.com	7000 W BEATRICE ST PHOENIX AZ 85043	555-8325	sed velit dapibus, quis tincidunt erat tincidunt. Aenean accumsan, erat nec volutpat placerat, lacus lorem volutpat sem, et ullamcorper
15	Jorge May	jorgemay@example.com	7070 W TRENTON WAY FLORENCE AZ 85132	555-6419	odio orci non velit. Nullam pharetra at nulla ac euismod. Fusce nec risus fringilla, hendrerit justo ut, finibus dui. In feugiat orci vel nisl
16	Stevie Conway	stevieconway@example.com	1641 E SHANNON ST CHANDLER AZ 85225	555-8166	semper, id mollis quam imperdiet. Ut quis egestas massa, ut interdum orci. Integer in ultrices magna. In pellentesque mauris id ex
17	Max Thornton	maxthornton@example.com	8601 N 71ST AVE GLENDALE AZ 85301	555-8150	rutrum, porta aliquet erat dapibus.
18	Jaya Turner	jayaturner@example.com	42201 W SALOME HWY TONOPAH AZ 85354	555-7887	Maecenas sagittis ipsum quis fringilla blandit. Etiam in tincidunt risus, et vulputate mauris. Sed cursus augue at lobortis mollis. Nam
19	Tanya Freeman	tanyafreeman@example.com	200 S ALANDALE PL TUCSON AZ 85710	555-4416	eleifend arcu eget ex feugiat.
20	Robyn Shields	robynshields@example.com	13863 N 109TH AVE SUN CITY AZ 85351	555-7345	Nam bibendum mollis finibus. Donec libero turpis, viverra nec ante varius, semper mattis risus. 
\.


--
-- TOC entry 3345 (class 0 OID 25432)
-- Dependencies: 215
-- Data for Name: orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.orders (o_oid, o_cid, o_price, o_date, o_type, o_status, o_comment) FROM stdin;
1	1	1425.00	2023-01-02	Standard	Delivered	Lorem ipsum dolor sit amet
2	2	1378.00	2023-02-18	Standard	Shipping	consectetur adipiscing elit
3	3	1323.00	2023-02-25	Standard	Processing	sed do eiusmod tempor
4	4	1311.00	2023-03-08	Express	Delivered	incididunt ut labore et dolore
5	5	1272.80	2023-03-19	Standard	Shipping	Ut enim ad minim veniam, quis nostrud exercitation
6	6	1164.20	2023-03-28	Express	Processing	ullamco laboris nisi ut
7	7	1150.20	2023-04-06	Express	Delivered	aliquip ex ea commodo consequat
8	8	1115.40	2023-04-11	Standard	Shipping	Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
9	9	1102.90	2023-04-21	Standard	Processing	Excepteur sint occaecat cupidatat non proident
10	10	1209.70	2023-04-23	Express	Delivered	sunt in culpa qui officia deserunt mollit
11	11	1229.00	2023-04-28	Standard	Shipping	Neque laoreet suspendisse interdum consectetur libero id faucibus.
12	12	1188.00	2023-05-11	Express	Processing	Arcu non odio euismod lacinia at quis risus sed vulputate
13	13	1231.00	2023-06-10	Standard	Delivered	Sagittis orci a scelerisque purus semper.
14	14	1201.00	2023-07-14	Standard	Shipping	Eu sem integer vitae justo eget magna fermentum iaculis.
15	15	1252.60	2023-07-31	Express	Processing	Elementum nibh tellus molestie nunc non. Adipiscing at in tellus integer feugiat.
16	16	1450.00	2023-08-19	Express	Delivered	Facilisi cras fermentum odio
17	17	1378.00	2023-08-22	Standard	Shipping	Consequat nisl vel pretium lectus quam id leo
18	18	1348.00	2023-08-25	Express	Processing	Mauris vitae ultricies leo integer malesuada.
19	19	1286.00	2023-08-31	Standard	Delivered	Quam quisque id diam vel quam elementum
20	20	1272.80	2023-10-07	Standard	Shipping	Massa sed elementum tempus egestas sed sed risus.
\.


--
-- TOC entry 3347 (class 0 OID 25459)
-- Dependencies: 217
-- Data for Name: part; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.part (p_pid, p_name, p_quantity, p_type, p_manufacturer, p_price) FROM stdin;
BX8071514900K	Core i9-14900K	13	CPU	Intel	132.00
BX8071513900KS	Core i9-13900KS	2586	CPU	Intel	131.00
BX8071514700K	Core i7-14700K	4	CPU	Intel	129.00
BX8071513900KF	Core i9-13900KF	10475	CPU	Intel	129.00
BX8071513900K	Core i9-13900K	49132	CPU	Intel	129.00
BX8071513700KF	Core i7-13700KF	14800	CPU	Intel	126.00
BX8071513700K	Core i7-13700K	41056	CPU	Intel	126.00
BX8071513900F	Core i9-13900F	457	CPU	Intel	124.00
BX8071513900	Core i9-13900	571	CPU	Intel	124.00
100-100000908WOF	Ryzen 9 7950X3D	525	CPU	AMD	122.00
GeForce RTX 4090 GAMING X TRIO 24G	MSI RTX 4090 24GB Gaming X Trio	12766	GPU	MSI	371.00
GV-N4090GAMING OC-24GD	Gigabyte RTX 4090 24GB Gaming OC	12766	GPU	Gigabyte	371.00
RTX 4090 SUPRIM Liquid X 24G	MSI RTX 4090 24GB Suprim Liquid X	12766	GPU	MSI	371.00
RTX 4090 SUPRIM X 24G	MSI RTX 4090 24GB Suprim X	12766	GPU	MSI	371.00
TUF-RTX4090-24G-GAMING	Asus RTX 4090 24GB TUF Gaming OC	12766	GPU	Asus	371.00
G408016SX	MSI RTX 4080 16GB Suprim X	13745	GPU	MSI	291.00
GV-N4080GAMING OC-16GD	Gigabyte RTX 4080 16GB Gaming OC	13745	GPU	Gigabyte	291.00
RTX 4080 16GB GAMING X TRIO	MSI RTX 4080 16GB Gaming X Trio	13745	GPU	MSI	291.00
RTX 4080 16GB VENTUS 3X OC	MSI RTX 4080 16GB Ventus 3X	13745	GPU	MSI	291.00
TUF-RTX4080-O16G-GAMING	Asus RTX 4080 16GB TUF Gaming OC	13745	GPU	Asus	291.00
ZT-D40810B-10P	Zotac RTX 4080 16GB AMP Extreme	13745	GPU	Zotac	291.00
GeForce RTX 4070 Ti VENTUS 3X 12G OC	MSI RTX 4070 Ti 12GB Ventus 3X OC	43161	GPU	MSI	240.00
GV-N407TEAGLE OC-12GD	Gigabyte RTX 4070 Ti 12GB Eagle OC	43161	GPU	Gigabyte	240.00
GV-N407TGAMING OC-12GD	Gigabyte RTX 4070 Ti 12GB 3X OC	43161	GPU	Gigabyte	240.00
WD121KRYZ	Gold 12TB (2017)	1221	HDD	WD	113.00
WD101KRYZ	Gold 10TB (2016)	1110	HDD	WD	107.00
WD6002FRYZ	Gold 6TB (2016) 	2043	HDD	WD	101.00
WD8003FRYZ	Gold 8TB (256MB Cache 2017)	695	HDD	WD	100.00
WD6002FFWX	Red Pro 6TB (2015)	995	HDD	WD	99.80
WD6002FZWX	Black 6TB (2016)	6443	HDD	WD	97.80
0S03839	Deskstar NAS 6TB	974	HDD	HGST	94.90
WD8002FRYZ	Gold 8TB (128MB Cache 2016)	288	HDD	WD	94.80
WD1000DHTZ	VelociRaptor 1TB	8165	HDD	WD	94.60
ST3000NC002	Constellation CS 3TB	667	HDD	Seagate	93.90
F4-2400C14Q2-128GRK	Ripjaws 4 DDR4 2400 C14 8x16GB	53	RAM	G.SKILL	121.00
F4-3200C14Q-64GTZ	Trident Z DDR4 3200 C14 4x16GB	1197	RAM	G.SKILL	116.00
BLS4K8G4D240FSA	Ballistix Sport DDR4 2400 C16 8x4GB	125	RAM	Crucial	110.00
BLE4K8G4D36BEEAK	Ballistix Elite DDR4 3600 C16 4x8GB	1449	RAM	Crucial	108.00
F4-3200C14Q-32GFX	Flare X DDR4 3200 C14 4x8GB	7103	RAM	G.SKILL	106.00
F4-3200C15Q-64GTZ	Trident Z DDR4 3200 C15 4x16GB	211	RAM	G.SKILL	103.00
CMD64GX4M4B3000C15	Dominator DDR4 3000 C15 4x16GB	133	RAM	Corsair	99.30
CMK32GX4M2Z3600C18	Vengeance LPX DDR4 3600 C18 2x16GB	17829	RAM	Corsair	98.60
F4-3600C16D-16GTZ	Trident Z DDR4 3600 C16 2x8GB	4081	RAM	G.SKILL	97.80
F4-3200C14D-16GFX	Flare X DDR4 3200 C14 2x8GB	54616	RAM	G.SKILL	97.80
WDS400T2X0E	Black SN850X NVMe PCIe M.2 4TB	2552	SSD	WD	537.00
WDS200T2X0E	Black SN850X NVMe PCIe M.2 2TB	17393	SSD	WD	510.00
MZ-V9P2T0B	990 Pro NVMe PCIe M.2 2TB	19488	SSD	Samsung	472.00
WDS200T1X0E	Black SN850 NVMe PCIe M.2 2TB	1131	SSD	WD	464.00
WDS100T2X0E	Black SN850X NVMe PCIe M.2 1TB	17582	SSD	WD	453.00
SSDPED1D280GASX	900P Optane NVMe PCIe 280GB	3427	SSD	Intel	440.00
SSDPE21D280GASX	900P Optane NVMe PCIe 280GB	3427	SSD	Intel	440.00
CT2000P5PSSD8	P5 Plus NVMe PCIe M.2 2TB	8566	SSD	Crucial	438.00
MZ-V8P2T0B	980 Pro NVMe PCIe M.2 2TB	89760	SSD	Samsung	431.00
SSDPED1D960GAX1	905P Optane NVMe PCIe 960GB	566	SSD	Intel	429.00
SSDPED1D480GASX	900P Optane NVMe PCIe 480GB	1995	SSD	Intel	429.00
SSDPE21D480GASX	900P Optane NVMe PCIe 480GB	1995	SSD	Intel	429.00
MKNUFDVU240GB	Ventura Ultra USB 3.0 240GB	27	USB	Mushkin	151.00
MKNUFDVU60GB	Ventura Ultra USB 3.0 60GB	38	USB	Mushkin	143.00
MKNUFDVU120GB	Ventura Ultra USB 3.0 120GB	48	USB	Mushkin	140.00
CMFVYGTX3-256GB	Flash Voyager GTX USB 3.0 256GB	71	USB	Corsair	114.00
CMFVYGTX3-128GB	Flash Voyager GTX USB 3.0 128GB	102	USB	Corsair	114.00
SDCZ88-128G	Extreme Pro USB 3.0 128GB	1435	USB	SanDisk	81.40
SDCZ80-064G	Extreme USB 3.0 64GB	6221	USB	SanDisk	74.00
MUF-64BB/US	FIT USB 3.0 64GB	4291	USB	Samsung	69.00
SDCZ80-032G	Extreme USB 3.0 32GB	4213	USB	SanDisk	64.50
\.


--
-- TOC entry 3197 (class 2606 OID 25468)
-- Name: comppart comppart_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.comppart
    ADD CONSTRAINT comppart_pkey PRIMARY KEY (cp_pid, cp_comp_id);


--
-- TOC entry 3193 (class 2606 OID 25448)
-- Name: computer computer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.computer
    ADD CONSTRAINT computer_pkey PRIMARY KEY (c_comp_id);


--
-- TOC entry 3189 (class 2606 OID 25431)
-- Name: customer customer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (cu_cid);


--
-- TOC entry 3191 (class 2606 OID 25438)
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (o_oid);


--
-- TOC entry 3195 (class 2606 OID 25463)
-- Name: part part_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.part
    ADD CONSTRAINT part_pkey PRIMARY KEY (p_pid);


--
-- TOC entry 3200 (class 2606 OID 25474)
-- Name: comppart comppart_cp_comp_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.comppart
    ADD CONSTRAINT comppart_cp_comp_id_fkey FOREIGN KEY (cp_comp_id) REFERENCES public.computer(c_comp_id);


--
-- TOC entry 3201 (class 2606 OID 25469)
-- Name: comppart comppart_cp_pid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.comppart
    ADD CONSTRAINT comppart_cp_pid_fkey FOREIGN KEY (cp_pid) REFERENCES public.part(p_pid);


--
-- TOC entry 3199 (class 2606 OID 25449)
-- Name: computer computer_c_oid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.computer
    ADD CONSTRAINT computer_c_oid_fkey FOREIGN KEY (c_oid) REFERENCES public.orders(o_oid) ON DELETE CASCADE;


--
-- TOC entry 3198 (class 2606 OID 25439)
-- Name: orders orders_o_cid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_o_cid_fkey FOREIGN KEY (o_cid) REFERENCES public.customer(cu_cid);


-- Completed on 2023-12-02 21:36:41

--
-- PostgreSQL database dump complete
--

