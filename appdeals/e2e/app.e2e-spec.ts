import { AppdealsPage } from './app.po';

describe('appdeals App', () => {
  let page: AppdealsPage;

  beforeEach(() => {
    page = new AppdealsPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
