// 0;TwinBuilder1.sml
//*************************************************************************************************
//                                           SML Netlist File                                     
//                                   created by Ansys Twin Builder 2021.1                            
//                                                                                                
//*************************************************************************************************


// begin toplevel circuit

INTERN SINE SINE3 (FREQ:=0.2, TPERIO:=Tend + 1, AMPL:=3, PHASE:=0, PERIO:=0, OFF:=0, TDELAY:=0 ) ;
INTERN SINE SINE2 (FREQ:=0.05, TPERIO:=Tend + 1, AMPL:=2, PHASE:=90, PERIO:=0, OFF:=0, TDELAY:=0 ) ;
INTERN SINE SINE1 (FREQ:=0.1, TPERIO:=Tend + 1, AMPL:=1, PHASE:=45, PERIO:=0, OFF:=0, TDELAY:=0 ) ;
MODEL SimplorerDataConnectorModel DataConnector1 ( Port:= 5010, TS:= 1, SyncToRT:= 1, ConnectionTimeout:= 20, IOTimeout:= 1, FromSimp1:= SINE1.VAL, FromSimp2:= SINE2.VAL, FromSimp3:= SINE3.VAL) SRC: DB(Lib:=) ;
// end toplevel circuit

SIMCTL TR
{
SIMCFG SIMPLORER_TR TR ( Tend := 40, Hmin := 1, Hmax := 1 );
}
OUTCTL OutCtl1
{
RESULT SDB SDB_0(DataConnector1.FromSimp1);
RESULT SDB SDB_1(DataConnector1.FromSimp2);
RESULT SDB SDB_2(DataConnector1.FromSimp3);
RESULT SDB SDB_3(DataConnector1.ToSimp1);
RESULT SDB SDB_4(DataConnector1.ToSimp2);
RESULT SDB SDB_5(SINE1.VAL);
RESULT SDB SDB_6(SINE2.VAL);
RESULT SDB SDB_7(SINE3.VAL);
RESULT VIEW VANALOG_0(DataConnector1.FromSimp1);
RESULT VIEW VANALOG_1(DataConnector1.FromSimp2);
RESULT VIEW VANALOG_2(DataConnector1.FromSimp3);
RESULT VIEW VANALOG_3(DataConnector1.ToSimp1);
RESULT VIEW VANALOG_4(DataConnector1.ToSimp2);
RESULT VIEW VANALOG_5(SINE1.VAL);
RESULT VIEW VANALOG_6(SINE2.VAL);
RESULT VIEW VANALOG_7(SINE3.VAL);
OUTCFG VIEWTOOL VT1 ( Xmin := 0, Xmax := Tend);
OUTCFG SimplorerDB DB1 ( Xmin := 0, Xmax := Tend);
}