namespace ``Grid Specification ``

open FsUnit
open Xunit
open FsUnit.Xunit
open Xunit.Extensions
open MonoGame.ConwaysGameOfLife
open Ploeh.AutoFixture

type ``When grid is loaded``()=
    
    let Fixture = new Fixture();

    let [<Fact>] ``Should load initial state``()=
        
         let cells = Fixture.CreateMany<Cell>();

         let sut = new Grid(cells);

         

