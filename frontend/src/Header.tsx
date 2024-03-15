import logo from './BowlingLeaguelogo.png';
function Header(prop: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{prop.title}</h1>
      </div>
    </header>
  );
}

export default Header;
