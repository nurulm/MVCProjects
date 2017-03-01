import { DealersAppPage } from './app.po';

describe('dealers-app App', function() {
  let page: DealersAppPage;

  beforeEach(() => {
    page = new DealersAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
